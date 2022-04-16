namespace Laboration4
{
    partial class WarehouseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.NewDelivery = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.AllowUserToAddRows = false;
            this.InventoryGridView.AllowUserToDeleteRows = false;
            this.InventoryGridView.AllowUserToResizeRows = false;
            this.InventoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryGridView.Location = new System.Drawing.Point(305, 0);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.ReadOnly = true;
            this.InventoryGridView.RowHeadersVisible = false;
            this.InventoryGridView.RowHeadersWidth = 51;
            this.InventoryGridView.RowTemplate.Height = 24;
            this.InventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGridView.Size = new System.Drawing.Size(1192, 986);
            this.InventoryGridView.TabIndex = 0;
            this.InventoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(3, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 64);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select row before pressing remove \r\nfrom inventory button or new delivery \r\nbutto" +
    "n. Before pressing new delivery, \r\nwrite the quantity in the text box.";
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.QuantityTextbox.ForeColor = System.Drawing.Color.Coral;
            this.QuantityTextbox.Location = new System.Drawing.Point(0, 46);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(305, 22);
            this.QuantityTextbox.TabIndex = 7;
            this.QuantityTextbox.TextChanged += new System.EventHandler(this.QuantityTextbox_TextChanged);
            // 
            // NewDelivery
            // 
            this.NewDelivery.FlatAppearance.BorderSize = 0;
            this.NewDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDelivery.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDelivery.ForeColor = System.Drawing.Color.Coral;
            this.NewDelivery.Image = global::Laboration4.Properties.Resources.plus_sign;
            this.NewDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewDelivery.Location = new System.Drawing.Point(0, 6);
            this.NewDelivery.Name = "NewDelivery";
            this.NewDelivery.Size = new System.Drawing.Size(302, 34);
            this.NewDelivery.TabIndex = 5;
            this.NewDelivery.Text = "New delivery";
            this.NewDelivery.UseVisualStyleBackColor = true;
            this.NewDelivery.Click += new System.EventHandler(this.NewDelivery_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 986);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NewDelivery);
            this.panel5.Controls.Add(this.QuantityTextbox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 76);
            this.panel5.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StatisticsButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 269);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(305, 47);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticsButton.FlatAppearance.BorderSize = 0;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.Coral;
            this.StatisticsButton.Image = global::Laboration4.Properties.Resources.stats;
            this.StatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatisticsButton.Location = new System.Drawing.Point(3, 3);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Padding = new System.Windows.Forms.Padding(3);
            this.StatisticsButton.Size = new System.Drawing.Size(302, 44);
            this.StatisticsButton.TabIndex = 4;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RemoveButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 45);
            this.panel4.TabIndex = 7;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Coral;
            this.RemoveButton.Image = global::Laboration4.Properties.Resources.delete;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveButton.Size = new System.Drawing.Size(305, 45);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove from inventory";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 52);
            this.panel3.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Coral;
            this.AddButton.Image = global::Laboration4.Properties.Resources.plus_sign;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(3);
            this.AddButton.Size = new System.Drawing.Size(305, 46);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add product to inventory";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SearchTextbox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 172);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(2, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search for item:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(85, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Coral;
            this.SearchTextbox.Location = new System.Drawing.Point(0, 144);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(305, 22);
            this.SearchTextbox.TabIndex = 10;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboration4.Properties.Resources.warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(79, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WarehouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.InventoryGridView);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseView";
            this.Size = new System.Drawing.Size(1497, 986);
            this.Load += new System.EventHandler(this.UserControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.Button NewDelivery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}
