namespace BestFurnitureDeals2._0.PresentationLayer
{
    partial class AdminDashboardForm
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
            this.furnitureGridView = new System.Windows.Forms.DataGridView();
            this.allProductsLabel = new System.Windows.Forms.Label();
            this.clientsOrdersLabel = new System.Windows.Forms.Label();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.nameFurnitureLabel = new System.Windows.Forms.Label();
            this.descriptionFurnitureLabel = new System.Windows.Forms.Label();
            this.typeFurnitureLabel = new System.Windows.Forms.Label();
            this.sellerFurnitureLabel = new System.Windows.Forms.Label();
            this.priceFurnitureLabel = new System.Windows.Forms.Label();
            this.numberOfProductsLabel = new System.Windows.Forms.Label();
            this.nameFurnitureText = new System.Windows.Forms.TextBox();
            this.typeFurnitureText = new System.Windows.Forms.TextBox();
            this.descriptionFurnitureRichBox = new System.Windows.Forms.RichTextBox();
            this.sellerFurnitureText = new System.Windows.Forms.TextBox();
            this.priceFurnitureText = new System.Windows.Forms.TextBox();
            this.numberProductsFurnitureText = new System.Windows.Forms.TextBox();
            this.addFurnitureButton = new System.Windows.Forms.Button();
            this.updateFurnitureButton = new System.Windows.Forms.Button();
            this.deleteFurnitureButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.updateOrderStatusButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureGridView
            // 
            this.furnitureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureGridView.Location = new System.Drawing.Point(42, 93);
            this.furnitureGridView.MultiSelect = false;
            this.furnitureGridView.Name = "furnitureGridView";
            this.furnitureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.furnitureGridView.Size = new System.Drawing.Size(623, 320);
            this.furnitureGridView.TabIndex = 0;
            this.furnitureGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.furnitureGridView_CellContentClick);
            // 
            // allProductsLabel
            // 
            this.allProductsLabel.AutoSize = true;
            this.allProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductsLabel.Location = new System.Drawing.Point(39, 33);
            this.allProductsLabel.Name = "allProductsLabel";
            this.allProductsLabel.Size = new System.Drawing.Size(184, 16);
            this.allProductsLabel.TabIndex = 1;
            this.allProductsLabel.Text = "Products in the database:";
            // 
            // clientsOrdersLabel
            // 
            this.clientsOrdersLabel.AutoSize = true;
            this.clientsOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsOrdersLabel.Location = new System.Drawing.Point(810, 33);
            this.clientsOrdersLabel.Name = "clientsOrdersLabel";
            this.clientsOrdersLabel.Size = new System.Drawing.Size(108, 16);
            this.clientsOrdersLabel.TabIndex = 2;
            this.clientsOrdersLabel.Text = "Clients orders:";
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(813, 81);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersGridView.Size = new System.Drawing.Size(453, 320);
            this.ordersGridView.TabIndex = 3;
            this.ordersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGridView_CellContentClick);
            // 
            // nameFurnitureLabel
            // 
            this.nameFurnitureLabel.AutoSize = true;
            this.nameFurnitureLabel.Location = new System.Drawing.Point(39, 461);
            this.nameFurnitureLabel.Name = "nameFurnitureLabel";
            this.nameFurnitureLabel.Size = new System.Drawing.Size(38, 13);
            this.nameFurnitureLabel.TabIndex = 4;
            this.nameFurnitureLabel.Text = "Name:";
            // 
            // descriptionFurnitureLabel
            // 
            this.descriptionFurnitureLabel.AutoSize = true;
            this.descriptionFurnitureLabel.Location = new System.Drawing.Point(39, 498);
            this.descriptionFurnitureLabel.Name = "descriptionFurnitureLabel";
            this.descriptionFurnitureLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionFurnitureLabel.TabIndex = 5;
            this.descriptionFurnitureLabel.Text = "Description:";
            // 
            // typeFurnitureLabel
            // 
            this.typeFurnitureLabel.AutoSize = true;
            this.typeFurnitureLabel.Location = new System.Drawing.Point(39, 588);
            this.typeFurnitureLabel.Name = "typeFurnitureLabel";
            this.typeFurnitureLabel.Size = new System.Drawing.Size(87, 13);
            this.typeFurnitureLabel.TabIndex = 6;
            this.typeFurnitureLabel.Text = "Type of furniture:";
            // 
            // sellerFurnitureLabel
            // 
            this.sellerFurnitureLabel.AutoSize = true;
            this.sellerFurnitureLabel.Location = new System.Drawing.Point(39, 643);
            this.sellerFurnitureLabel.Name = "sellerFurnitureLabel";
            this.sellerFurnitureLabel.Size = new System.Drawing.Size(36, 13);
            this.sellerFurnitureLabel.TabIndex = 7;
            this.sellerFurnitureLabel.Text = "Seller:";
            // 
            // priceFurnitureLabel
            // 
            this.priceFurnitureLabel.AutoSize = true;
            this.priceFurnitureLabel.Location = new System.Drawing.Point(39, 692);
            this.priceFurnitureLabel.Name = "priceFurnitureLabel";
            this.priceFurnitureLabel.Size = new System.Drawing.Size(34, 13);
            this.priceFurnitureLabel.TabIndex = 8;
            this.priceFurnitureLabel.Text = "Price:";
            // 
            // numberOfProductsLabel
            // 
            this.numberOfProductsLabel.AutoSize = true;
            this.numberOfProductsLabel.Location = new System.Drawing.Point(39, 735);
            this.numberOfProductsLabel.Name = "numberOfProductsLabel";
            this.numberOfProductsLabel.Size = new System.Drawing.Size(107, 13);
            this.numberOfProductsLabel.TabIndex = 9;
            this.numberOfProductsLabel.Text = "Number of Products: ";
            // 
            // nameFurnitureText
            // 
            this.nameFurnitureText.Location = new System.Drawing.Point(188, 461);
            this.nameFurnitureText.Name = "nameFurnitureText";
            this.nameFurnitureText.Size = new System.Drawing.Size(295, 20);
            this.nameFurnitureText.TabIndex = 10;
            // 
            // typeFurnitureText
            // 
            this.typeFurnitureText.Location = new System.Drawing.Point(188, 588);
            this.typeFurnitureText.Name = "typeFurnitureText";
            this.typeFurnitureText.Size = new System.Drawing.Size(295, 20);
            this.typeFurnitureText.TabIndex = 11;
            // 
            // descriptionFurnitureRichBox
            // 
            this.descriptionFurnitureRichBox.Location = new System.Drawing.Point(188, 498);
            this.descriptionFurnitureRichBox.Name = "descriptionFurnitureRichBox";
            this.descriptionFurnitureRichBox.Size = new System.Drawing.Size(477, 65);
            this.descriptionFurnitureRichBox.TabIndex = 12;
            this.descriptionFurnitureRichBox.Text = "";
            // 
            // sellerFurnitureText
            // 
            this.sellerFurnitureText.Location = new System.Drawing.Point(188, 643);
            this.sellerFurnitureText.Name = "sellerFurnitureText";
            this.sellerFurnitureText.Size = new System.Drawing.Size(295, 20);
            this.sellerFurnitureText.TabIndex = 13;
            // 
            // priceFurnitureText
            // 
            this.priceFurnitureText.Location = new System.Drawing.Point(188, 689);
            this.priceFurnitureText.Name = "priceFurnitureText";
            this.priceFurnitureText.Size = new System.Drawing.Size(295, 20);
            this.priceFurnitureText.TabIndex = 14;
            // 
            // numberProductsFurnitureText
            // 
            this.numberProductsFurnitureText.Location = new System.Drawing.Point(188, 735);
            this.numberProductsFurnitureText.Name = "numberProductsFurnitureText";
            this.numberProductsFurnitureText.Size = new System.Drawing.Size(295, 20);
            this.numberProductsFurnitureText.TabIndex = 15;
            // 
            // addFurnitureButton
            // 
            this.addFurnitureButton.Location = new System.Drawing.Point(96, 799);
            this.addFurnitureButton.Name = "addFurnitureButton";
            this.addFurnitureButton.Size = new System.Drawing.Size(92, 35);
            this.addFurnitureButton.TabIndex = 16;
            this.addFurnitureButton.Text = "Add Furniture";
            this.addFurnitureButton.UseVisualStyleBackColor = true;
            this.addFurnitureButton.Click += new System.EventHandler(this.addFurnitureButton_Click);
            // 
            // updateFurnitureButton
            // 
            this.updateFurnitureButton.Location = new System.Drawing.Point(242, 799);
            this.updateFurnitureButton.Name = "updateFurnitureButton";
            this.updateFurnitureButton.Size = new System.Drawing.Size(92, 35);
            this.updateFurnitureButton.TabIndex = 17;
            this.updateFurnitureButton.Text = "Update Furniture";
            this.updateFurnitureButton.UseVisualStyleBackColor = true;
            this.updateFurnitureButton.Click += new System.EventHandler(this.updateFurnitureButton_Click);
            // 
            // deleteFurnitureButton
            // 
            this.deleteFurnitureButton.Location = new System.Drawing.Point(391, 799);
            this.deleteFurnitureButton.Name = "deleteFurnitureButton";
            this.deleteFurnitureButton.Size = new System.Drawing.Size(92, 35);
            this.deleteFurnitureButton.TabIndex = 18;
            this.deleteFurnitureButton.Text = "Delete Furniture";
            this.deleteFurnitureButton.UseVisualStyleBackColor = true;
            this.deleteFurnitureButton.Click += new System.EventHandler(this.deleteFurnitureButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(683, 899);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 19;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // updateOrderStatusButton
            // 
            this.updateOrderStatusButton.Location = new System.Drawing.Point(980, 515);
            this.updateOrderStatusButton.Name = "updateOrderStatusButton";
            this.updateOrderStatusButton.Size = new System.Drawing.Size(147, 48);
            this.updateOrderStatusButton.TabIndex = 20;
            this.updateOrderStatusButton.Text = "Update Order Status";
            this.updateOrderStatusButton.UseVisualStyleBackColor = true;
            this.updateOrderStatusButton.Click += new System.EventHandler(this.updateOrderStatusButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(991, 444);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 21;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1413, 971);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.updateOrderStatusButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.deleteFurnitureButton);
            this.Controls.Add(this.updateFurnitureButton);
            this.Controls.Add(this.addFurnitureButton);
            this.Controls.Add(this.numberProductsFurnitureText);
            this.Controls.Add(this.priceFurnitureText);
            this.Controls.Add(this.sellerFurnitureText);
            this.Controls.Add(this.descriptionFurnitureRichBox);
            this.Controls.Add(this.typeFurnitureText);
            this.Controls.Add(this.nameFurnitureText);
            this.Controls.Add(this.numberOfProductsLabel);
            this.Controls.Add(this.priceFurnitureLabel);
            this.Controls.Add(this.sellerFurnitureLabel);
            this.Controls.Add(this.typeFurnitureLabel);
            this.Controls.Add(this.descriptionFurnitureLabel);
            this.Controls.Add(this.nameFurnitureLabel);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.clientsOrdersLabel);
            this.Controls.Add(this.allProductsLabel);
            this.Controls.Add(this.furnitureGridView);
            this.Name = "AdminDashboardForm";
            this.Text = "Panel de management";
            ((System.ComponentModel.ISupportInitialize)(this.furnitureGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView furnitureGridView;
        private System.Windows.Forms.Label allProductsLabel;
        private System.Windows.Forms.Label clientsOrdersLabel;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Label nameFurnitureLabel;
        private System.Windows.Forms.Label descriptionFurnitureLabel;
        private System.Windows.Forms.Label typeFurnitureLabel;
        private System.Windows.Forms.Label sellerFurnitureLabel;
        private System.Windows.Forms.Label priceFurnitureLabel;
        private System.Windows.Forms.Label numberOfProductsLabel;
        private System.Windows.Forms.TextBox nameFurnitureText;
        private System.Windows.Forms.TextBox typeFurnitureText;
        private System.Windows.Forms.RichTextBox descriptionFurnitureRichBox;
        private System.Windows.Forms.TextBox sellerFurnitureText;
        private System.Windows.Forms.TextBox priceFurnitureText;
        private System.Windows.Forms.TextBox numberProductsFurnitureText;
        private System.Windows.Forms.Button addFurnitureButton;
        private System.Windows.Forms.Button updateFurnitureButton;
        private System.Windows.Forms.Button deleteFurnitureButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button updateOrderStatusButton;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}