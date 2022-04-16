namespace Laboration4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WarehouseTab = new System.Windows.Forms.TabPage();
            this.CashregisterTab = new System.Windows.Forms.TabPage();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WarehouseTab);
            this.tabControl1.Controls.Add(this.CashregisterTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1842, 845);
            this.tabControl1.TabIndex = 4;
            // 
            // WarehouseTab
            // 
            this.WarehouseTab.BackColor = System.Drawing.SystemColors.Window;
            this.WarehouseTab.Location = new System.Drawing.Point(4, 25);
            this.WarehouseTab.Name = "WarehouseTab";
            this.WarehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.WarehouseTab.Size = new System.Drawing.Size(1834, 816);
            this.WarehouseTab.TabIndex = 0;
            this.WarehouseTab.Text = "Warehouse";
            // 
            // CashregisterTab
            // 
            this.CashregisterTab.BackColor = System.Drawing.SystemColors.Window;
            this.CashregisterTab.Location = new System.Drawing.Point(4, 25);
            this.CashregisterTab.Name = "CashregisterTab";
            this.CashregisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.CashregisterTab.Size = new System.Drawing.Size(1592, 871);
            this.CashregisterTab.TabIndex = 1;
            this.CashregisterTab.Text = "Cash Register";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1842, 845);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Media Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += MainForm_FormClosed;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WarehouseTab;
        private System.Windows.Forms.TabPage CashregisterTab;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}

