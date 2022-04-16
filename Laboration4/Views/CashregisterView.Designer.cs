namespace Laboration4
{
    partial class CashregisterView
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RemoveCartButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RepurchaseButton = new System.Windows.Forms.Button();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
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
            this.InventoryGridView.Location = new System.Drawing.Point(0, 0);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.ReadOnly = true;
            this.InventoryGridView.RowHeadersVisible = false;
            this.InventoryGridView.RowHeadersWidth = 51;
            this.InventoryGridView.RowTemplate.Height = 24;
            this.InventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGridView.Size = new System.Drawing.Size(951, 499);
            this.InventoryGridView.TabIndex = 0;
            this.InventoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(79, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shopping Cart";
            // 
            // CartGridView
            // 
            this.CartGridView.AllowUserToAddRows = false;
            this.CartGridView.AllowUserToDeleteRows = false;
            this.CartGridView.AllowUserToResizeRows = false;
            this.CartGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CartGridView.Location = new System.Drawing.Point(0, 0);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.RowHeadersVisible = false;
            this.CartGridView.RowHeadersWidth = 51;
            this.CartGridView.RowTemplate.Height = 24;
            this.CartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGridView.Size = new System.Drawing.Size(951, 255);
            this.CartGridView.TabIndex = 0;
            this.CartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 789);
            this.panel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CheckoutButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 630);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 45);
            this.panel7.TabIndex = 14;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckoutButton.FlatAppearance.BorderSize = 0;
            this.CheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckoutButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.Coral;
            this.CheckoutButton.Image = global::Laboration4.Properties.Resources.checkout;
            this.CheckoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckoutButton.Location = new System.Drawing.Point(0, 0);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(305, 38);
            this.CheckoutButton.TabIndex = 6;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RemoveCartButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 583);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 47);
            this.panel6.TabIndex = 13;
            // 
            // RemoveCartButton
            // 
            this.RemoveCartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveCartButton.FlatAppearance.BorderSize = 0;
            this.RemoveCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCartButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCartButton.ForeColor = System.Drawing.Color.Coral;
            this.RemoveCartButton.Image = global::Laboration4.Properties.Resources.remove_from_cart;
            this.RemoveCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveCartButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveCartButton.Name = "RemoveCartButton";
            this.RemoveCartButton.Size = new System.Drawing.Size(305, 38);
            this.RemoveCartButton.TabIndex = 5;
            this.RemoveCartButton.Text = "Remove cart";
            this.RemoveCartButton.UseVisualStyleBackColor = true;
            this.RemoveCartButton.Click += new System.EventHandler(this.RemoveCartButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RemoveItemButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 538);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 45);
            this.panel5.TabIndex = 12;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveItemButton.FlatAppearance.BorderSize = 0;
            this.RemoveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItemButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemButton.ForeColor = System.Drawing.Color.Coral;
            this.RemoveItemButton.Image = global::Laboration4.Properties.Resources.shopping_cart;
            this.RemoveItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveItemButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(305, 38);
            this.RemoveItemButton.TabIndex = 4;
            this.RemoveItemButton.Text = "Remove from cart";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 123);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Laboration4.Properties.Resources.shopping;
            this.pictureBox2.Location = new System.Drawing.Point(97, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.SearchTextbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 282);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search for item:";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Coral;
            this.SearchTextbox.Location = new System.Drawing.Point(0, 26);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(305, 22);
            this.SearchTextbox.TabIndex = 2;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 133);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboration4.Properties.Resources.warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(97, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RepurchaseButton
            // 
            this.RepurchaseButton.FlatAppearance.BorderSize = 0;
            this.RepurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepurchaseButton.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepurchaseButton.ForeColor = System.Drawing.Color.Coral;
            this.RepurchaseButton.Image = global::Laboration4.Properties.Resources.repurchase;
            this.RepurchaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RepurchaseButton.Location = new System.Drawing.Point(385, 3);
            this.RepurchaseButton.Name = "RepurchaseButton";
            this.RepurchaseButton.Size = new System.Drawing.Size(166, 29);
            this.RepurchaseButton.TabIndex = 1;
            this.RepurchaseButton.Text = "Repurchase";
            this.RepurchaseButton.UseVisualStyleBackColor = true;
            this.RepurchaseButton.Click += new System.EventHandler(this.RepurchaseButton_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.FlatAppearance.BorderSize = 0;
            this.AddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartButton.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ForeColor = System.Drawing.Color.Coral;
            this.AddToCartButton.Image = global::Laboration4.Properties.Resources.add_to_cart;
            this.AddToCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToCartButton.Location = new System.Drawing.Point(160, 3);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(140, 29);
            this.AddToCartButton.TabIndex = 0;
            this.AddToCartButton.Text = "Add to ";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.InventoryGridView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(305, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(951, 499);
            this.panel8.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel9.Controls.Add(this.RepurchaseButton);
            this.panel9.Controls.Add(this.AddToCartButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(305, 499);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(951, 35);
            this.panel9.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CartGridView);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(305, 534);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(951, 255);
            this.panel10.TabIndex = 11;
            // 
            // CashregisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "CashregisterView";
            this.Size = new System.Drawing.Size(1256, 789);
            this.Load += new System.EventHandler(this.UserControlLoad);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.Button RepurchaseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button RemoveCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextbox;
    }
}
