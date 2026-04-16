using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 디자인 파일(Designer.cs)에서 참조하는 로드 이벤트 메서드입니다. 
        // 삭제 시 빌드 에러가 발생하므로 내용을 비워두더라도 유지해야 합니다.
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region 폴더 선택 및 리스트 갱신

        // 왼쪽 폴더 선택 버튼
        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    RefreshLists();
                }
            }
        }

        // 오른쪽 폴더 선택 버튼
        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    RefreshLists();
                }
            }
        }

        // 양쪽 리스트를 동시에 최신 상태로 갱신 (색상 비교 포함)
        private void RefreshLists()
        {
            PopulateListView(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
        }

        #endregion

        #region 리스트 뷰 데이터 채우기 및 비교 로직

        private void PopulateListView(ListView lv, string folderPath, string oppositePath)
        {
            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath)) return;

            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                DirectoryInfo currentDir = new DirectoryInfo(folderPath);

                // 반대편 폴더의 파일 목록을 미리 읽어 비교 준비 (Dictionary 사용으로 속도 최적화)
                Dictionary<string, FileInfo> oppositeFiles = new Dictionary<string, FileInfo>();
                if (!string.IsNullOrWhiteSpace(oppositePath) && Directory.Exists(oppositePath))
                {
                    oppositeFiles = Directory.EnumerateFiles(oppositePath)
                                             .Select(p => new FileInfo(p))
                                             .ToDictionary(f => f.Name, f => f);
                }

                // 1. 하위 폴더 목록 추가
                foreach (var d in currentDir.GetDirectories().OrderBy(d => d.Name))
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                // 2. 파일 목록 추가 및 색상 비교 처리
                foreach (var lf in currentDir.GetFiles().OrderBy(f => f.Name))
                {
                    var litem = new ListViewItem(lf.Name);
                    litem.SubItems.Add((lf.Length / 1024.0).ToString("N1") + " KB");
                    litem.SubItems.Add(lf.LastWriteTime.ToString("g"));

                    // --- 비교 결과에 따른 색상 설정 ---
                    if (oppositeFiles.TryGetValue(lf.Name, out var rf))
                    {
                        // 양쪽 폴더에 모두 존재할 때
                        if (lf.LastWriteTime == rf.LastWriteTime)
                            litem.ForeColor = Color.Black; // 수정시간 같으면 검정
                        else
                            litem.ForeColor = Color.Red;   // 수정시간 다르면 빨강
                    }
                    else
                    {
                        // 반대편 폴더에 존재하지 않을 때
                        litem.ForeColor = Color.Blue;      // 파랑
                    }

                    lv.Items.Add(litem);
                }

                // 컬럼 너비 자동 조정
                foreach (ColumnHeader col in lv.Columns)
                    col.Width = -2;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"목록을 읽는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        #endregion

        #region 파일 복사 기능

        // 파일 복사 실행 (왼쪽 -> 오른쪽)
        private void btnCopyToRight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRightDir.Text))
            {
                MessageBox.Show("대상 폴더를 먼저 선택해주세요.");
                return;
            }

            if (lvwLeftDir.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in lvwLeftDir.SelectedItems)
            {
                string srcPath = Path.Combine(txtLeftDir.Text, item.Text);
                string destPath = Path.Combine(txtRightDir.Text, item.Text);

                // 폴더가 아닌 파일인 경우에만 복사 수행
                if (File.Exists(srcPath))
                {
                    CopyFileWithConfirmation(srcPath, destPath);
                }
            }
            RefreshLists(); // 복사 완료 후 색상 갱신을 위해 리스트 새로고침
        }

        private void CopyFileWithConfirmation(string srcPath, string destPath)
        {
            try
            {
                if (File.Exists(destPath))
                {
                    var srcInfo = new FileInfo(srcPath);
                    var destInfo = new FileInfo(destPath);

                    string msg = $"대상에 동일한 이름의 파일이 이미 있습니다. 덮어쓰시겠습니까?\n\n" +
                                 $"[원본] 수정일: {srcInfo.LastWriteTime}\n" +
                                 $"[대상] 수정일: {destInfo.LastWriteTime}";

                    if (MessageBox.Show(msg, "복사 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }
                File.Copy(srcPath, destPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파일 복사 중 오류 발생: {ex.Message}");
            }
        }

        #endregion

        #region 기타 이벤트 핸들러 (삭제 금지)

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void lblAppName_Click(object sender, EventArgs e) { }

        #endregion
    }
}