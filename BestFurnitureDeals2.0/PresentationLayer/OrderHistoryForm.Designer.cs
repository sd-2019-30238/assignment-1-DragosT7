namespace BestFurnitureDeals2._0.PresentationLayer
{
    partial class OrderHistoryForm
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
            this.orderHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addFeedbackButton = new System.Windows.Forms.Button();
            this.feedbackRichBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderHistoryDataGrid
            // 
            this.orderHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDataGrid.Location = new System.Drawing.Point(96, 98);
            this.orderHistoryDataGrid.Name = "orderHistoryDataGrid";
            this.orderHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderHistoryDataGrid.Size = new System.Drawing.Size(412, 265);
            this.orderHistoryDataGrid.TabIndex = 0;
            this.orderHistoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderHistoryDataGrid_CellContentClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(93, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(81, 16);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "My orders:";
            // 
            // addFeedbackButton
            // 
            this.addFeedbackButton.Location = new System.Drawing.Point(695, 314);
            this.addFeedbackButton.Name = "addFeedbackButton";
            this.addFeedbackButton.Size = new System.Drawing.Size(145, 49);
            this.addFeedbackButton.TabIndex = 3;
            this.addFeedbackButton.Text = "Add feedback";
            this.addFeedbackButton.UseVisualStyleBackColor = true;
            this.addFeedbackButton.Click += new System.EventHandler(this.addFeedbackButton_Click);
            // 
            // feedbackRichBox
            // 
            this.feedbackRichBox.Location = new System.Drawing.Point(627, 98);
            this.feedbackRichBox.Name = "feedbackRichBox";
            this.feedbackRichBox.Size = new System.Drawing.Size(274, 156);
            this.feedbackRichBox.TabIndex = 4;
            this.feedbackRichBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(464, 454);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.feedbackRichBox);
            this.Controls.Add(this.addFeedbackButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.orderHistoryDataGrid);
            this.Name = "OrderHistoryForm";
            this.Text = "OrderHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderHistoryDataGrid;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addFeedbackButton;
        private System.Windows.Forms.RichTextBox feedbackRichBox;
        private System.Windows.Forms.Button exitButton;
    }
}