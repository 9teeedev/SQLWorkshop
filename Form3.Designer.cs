namespace WinFormsApp104
{
    partial class Form3
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
            cboCategory = new ComboBox();
            btnShowCategory = new Button();
            dgvCategory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(194, 35);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(299, 23);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(512, 34);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(75, 23);
            btnShowCategory.TabIndex = 1;
            btnShowCategory.Text = "Show";
            btnShowCategory.UseVisualStyleBackColor = true;
            btnShowCategory.Click += button1_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(12, 77);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Size = new Size(776, 361);
            dgvCategory.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategory);
            Controls.Add(btnShowCategory);
            Controls.Add(cboCategory);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCategory;
        private Button btnShowCategory;
        private DataGridView dgvCategory;
    }
}