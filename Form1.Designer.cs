namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            panel2 = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            panel1 = new Panel();
            lblAppName = new Label();
            btnCopyfromLeft = new Button();
            panel6 = new Panel();
            lvwRightDir = new ListView();
            panel5 = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panel4 = new Panel();
            btnCopyfromRight = new Button();
            name = new ColumnHeader();
            date = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Padding = new Padding(5);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(1601, 875);
            splitContainer1.SplitterDistance = 807;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 541);
            panel3.TabIndex = 0;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4 });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(797, 541);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtLeftDir);
            panel2.Controls.Add(btnLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 124);
            panel2.TabIndex = 0;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtLeftDir.Font = new Font("맑은 고딕", 14F);
            txtLeftDir.Location = new Point(7, 31);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(577, 57);
            txtLeftDir.TabIndex = 1;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 12F);
            btnLeftDir.Location = new Point(615, 23);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(166, 65);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAppName);
            panel1.Controls.Add(btnCopyfromLeft);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 200);
            panel1.TabIndex = 5;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 23F);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(43, 30);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(406, 84);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            lblAppName.Click += lblAppName_Click;
            // 
            // btnCopyfromLeft
            // 
            btnCopyfromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyfromLeft.Font = new Font("맑은 고딕", 12F);
            btnCopyfromLeft.Location = new Point(592, 100);
            btnCopyfromLeft.Name = "btnCopyfromLeft";
            btnCopyfromLeft.Size = new Size(166, 64);
            btnCopyfromLeft.TabIndex = 3;
            btnCopyfromLeft.Text = ">>>";
            btnCopyfromLeft.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwRightDir);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 329);
            panel6.Name = "panel6";
            panel6.Size = new Size(790, 546);
            panel6.TabIndex = 0;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { name, date, columnHeader3 });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(3, 6);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(784, 528);
            lvwRightDir.TabIndex = 0;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtRightDir);
            panel5.Controls.Add(btnRightDir);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(790, 124);
            panel5.TabIndex = 0;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRightDir.Font = new Font("맑은 고딕", 14F);
            txtRightDir.Location = new Point(25, 31);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(567, 57);
            txtRightDir.TabIndex = 2;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRightDir.Font = new Font("맑은 고딕", 11F);
            btnRightDir.Location = new Point(624, 25);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(154, 65);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyfromRight);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(790, 205);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // btnCopyfromRight
            // 
            btnCopyfromRight.Font = new Font("맑은 고딕", 12F);
            btnCopyfromRight.Location = new Point(51, 105);
            btnCopyfromRight.Name = "btnCopyfromRight";
            btnCopyfromRight.Size = new Size(167, 64);
            btnCopyfromRight.TabIndex = 4;
            btnCopyfromRight.Text = "<<<";
            btnCopyfromRight.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Text = "이름";
            name.Width = 300;
            // 
            // date
            // 
            date.Text = "크기";
            date.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 280;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "수정일";
            columnHeader4.Width = 290;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 875);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "File Compare v1.0";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblAppName;
        private Button btnLeftDir;
        private TextBox txtLeftDir;
        private Button btnRightDir;
        private TextBox txtRightDir;
        private Button btnCopyfromLeft;
        private Button btnCopyfromRight;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private ListView lvwLeftDir;
        private ListView lvwRightDir;
        private ColumnHeader name;
        private ColumnHeader date;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
    }
}
