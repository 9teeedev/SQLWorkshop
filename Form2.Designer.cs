namespace WinFormsApp104
{
    partial class Form2
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
            dgvResult = new DataGridView();
            cboCountry = new ComboBox();
            btnShow = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 72);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(776, 310);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(178, 43);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(121, 23);
            cboCountry.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(321, 43);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "เลือกประเภทลูกค้า";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(cboCountry);
            Controls.Add(dgvResult);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private ComboBox cboCountry;
        private Button btnShow;
        private Label label1;
    }
}