namespace WinFormsApp104
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            workshopToolStripMenuItem = new ToolStripMenuItem();
            workshop1ToolStripMenuItem = new ToolStripMenuItem();
            workshop2ToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            workshop4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkUpdateToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workshop1ToolStripMenuItem, workshop2ToolStripMenuItem, ordersToolStripMenuItem, workshop4ToolStripMenuItem });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(93, 25);
            workshopToolStripMenuItem.Text = "Workshop";
            // 
            // workshop1ToolStripMenuItem
            // 
            workshop1ToolStripMenuItem.Name = "workshop1ToolStripMenuItem";
            workshop1ToolStripMenuItem.Size = new Size(169, 26);
            workshop1ToolStripMenuItem.Text = "Workshop#1";
            workshop1ToolStripMenuItem.Click += workshop1ToolStripMenuItem_Click;
            // 
            // workshop2ToolStripMenuItem
            // 
            workshop2ToolStripMenuItem.Name = "workshop2ToolStripMenuItem";
            workshop2ToolStripMenuItem.Size = new Size(169, 26);
            workshop2ToolStripMenuItem.Text = "Workshop#2";
            workshop2ToolStripMenuItem.Click += workshop2ToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(169, 26);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // workshop4ToolStripMenuItem
            // 
            workshop4ToolStripMenuItem.Name = "workshop4ToolStripMenuItem";
            workshop4ToolStripMenuItem.Size = new Size(169, 26);
            workshop4ToolStripMenuItem.Text = "Workshop#4";
            workshop4ToolStripMenuItem.Click += workshop4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, checkUpdateToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(54, 25);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(176, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // checkUpdateToolStripMenuItem
            // 
            checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            checkUpdateToolStripMenuItem.Size = new Size(176, 26);
            checkUpdateToolStripMenuItem.Text = "Check Update";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopToolStripMenuItem;
        private ToolStripMenuItem workshop1ToolStripMenuItem;
        private ToolStripMenuItem workshop2ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem checkUpdateToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem workshop4ToolStripMenuItem;
    }
}