namespace BestFurnitureDeals2._0.PresentationLayer
{
    partial class ClientViewForm
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
            this.availableDealsLabel = new System.Windows.Forms.Label();
            this.availableDealsDataGrid = new System.Windows.Forms.DataGridView();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.deleteFromCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availableDealsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availableDealsLabel
            // 
            this.availableDealsLabel.AutoSize = true;
            this.availableDealsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableDealsLabel.Location = new System.Drawing.Point(74, 63);
            this.availableDealsLabel.Name = "availableDealsLabel";
            this.availableDealsLabel.Size = new System.Drawing.Size(121, 16);
            this.availableDealsLabel.TabIndex = 0;
            this.availableDealsLabel.Text = "Available deals:";
            // 
            // availableDealsDataGrid
            // 
            this.availableDealsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableDealsDataGrid.Location = new System.Drawing.Point(77, 120);
            this.availableDealsDataGrid.Name = "availableDealsDataGrid";
            this.availableDealsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableDealsDataGrid.Size = new System.Drawing.Size(485, 261);
            this.availableDealsDataGrid.TabIndex = 1;
            this.availableDealsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableDealsDataGrid_CellContentClick);
            // 
            // cartGridView
            // 
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Location = new System.Drawing.Point(696, 120);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGridView.Size = new System.Drawing.Size(358, 261);
            this.cartGridView.TabIndex = 2;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(693, 63);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(110, 16);
            this.shoppingCartLabel.TabIndex = 3;
            this.shoppingCartLabel.Text = "Shopping Cart:";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(487, 413);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(75, 23);
            this.addToCartButton.TabIndex = 4;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // deleteFromCartButton
            // 
            this.deleteFromCartButton.Location = new System.Drawing.Point(696, 413);
            this.deleteFromCartButton.Name = "deleteFromCartButton";
            this.deleteFromCartButton.Size = new System.Drawing.Size(123, 23);
            this.deleteFromCartButton.TabIndex = 5;
            this.deleteFromCartButton.Text = "Delete from Cart";
            this.deleteFromCartButton.UseVisualStyleBackColor = true;
            this.deleteFromCartButton.Click += new System.EventHandler(this.deleteFromCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(890, 413);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(106, 23);
            this.checkoutButton.TabIndex = 7;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(77, 26);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(106, 23);
            this.signOutButton.TabIndex = 8;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // ClientViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 507);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.deleteFromCartButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.cartGridView);
            this.Controls.Add(this.availableDealsDataGrid);
            this.Controls.Add(this.availableDealsLabel);
            this.Name = "ClientViewForm";
            this.Text = "ClientViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.availableDealsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableDealsLabel;
        private System.Windows.Forms.DataGridView availableDealsDataGrid;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button deleteFromCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button signOutButton;
    }
}