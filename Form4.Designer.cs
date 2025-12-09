namespace WinFormsApp104
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dgvResult = new DataGridView();
            label9 = new Label();
            lbRecord = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrev = new Button();
            btnFirst = new Button();
            txtTitle = new TextBox();
            txtContact = new TextBox();
            txtCompany = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnShowAll = new Button();
            btnSearch = new Button();
            cboCountry = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvResult);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbRecord);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnPrev);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(txtCompany);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnShowAll);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(cboCountry);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 646);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(6, 362);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(667, 278);
            dgvResult.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 344);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 19;
            label9.Text = "ข้อมูลลูกค้า";
            // 
            // lbRecord
            // 
            lbRecord.Location = new Point(212, 295);
            lbRecord.Name = "lbRecord";
            lbRecord.Size = new Size(193, 23);
            lbRecord.TabIndex = 18;
            lbRecord.Text = "label8";
            lbRecord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(462, 295);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(45, 25);
            btnLast.TabIndex = 17;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(411, 295);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 25);
            btnNext.TabIndex = 16;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(162, 295);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(45, 25);
            btnPrev.TabIndex = 15;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(111, 295);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(45, 25);
            btnFirst.TabIndex = 14;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(148, 248);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(308, 23);
            txtTitle.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(148, 216);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(308, 23);
            txtContact.TabIndex = 12;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(148, 176);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(308, 23);
            txtCompany.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(148, 140);
            txtID.Name = "txtID";
            txtID.Size = new Size(308, 23);
            txtID.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 251);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 9;
            label7.Text = "ตำแหน่งผู้ติดต่อ : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 216);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "ชื่อผู้ติดต่อ : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 179);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 7;
            label5.Text = "ชื่อบริษัท : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 143);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "รหัสลูกค้า : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "ข้อมูลลูกค้า";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(560, 49);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "ทั้งหมด";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(462, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "ค้นหา";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(148, 49);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(308, 23);
            cboCountry.TabIndex = 2;
            cboCountry.SelectedIndexChanged += cboCounty_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 52);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "เลือกประเทศ : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "ค้นหาลูกค้าตามประเทศที่อาศัย";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ComboBox cboCountry;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Button btnFirst;
        private TextBox txtTitle;
        private TextBox txtContact;
        private TextBox txtCompany;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label lbRecord;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrev;
        private Button btnShowAll;
        private Button btnSearch;
        private DataGridView dgvResult;
    }
}