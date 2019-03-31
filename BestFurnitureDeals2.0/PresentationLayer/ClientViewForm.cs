using BestFurnitureDeals2._0.BusinessLogic;
using BestFurnitureDeals2._0.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFurnitureDeals2._0.PresentationLayer
{
    public partial class ClientViewForm : Form
    {
        private FurnitureController furnitureController;
        private OrderController orderController;

        private int itemID;
        private int orderID;
        private int orderItemID;
        private int furnitureID;
        
        public ClientViewForm()
        {
            InitializeComponent();
            this.furnitureController = Utils.FurnitureController;
            this.orderController = Utils.OrderController;
            this.loadDataGridView();
            this.loadOrderItemsGridView();
        }

        private void loadDataGridView()
        {
            this.availableDealsDataGrid.DataSource = furnitureController.DisplayAllFurniture();
            this.availableDealsDataGrid.ReadOnly = true;
            this.availableDealsDataGrid.Refresh();
        }

        private void loadOrderItemsGridView()
        {
            this.cartGridView.DataSource = orderController.DisplayAllCartItems(Utils.userID);
            this.cartGridView.ReadOnly = true;
            
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Utils.PrevForm.Show();
            this.Close();
        }
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (this.availableDealsDataGrid.SelectedRows.Count == 0)
            {
                return;
            }
            
            var row = this.availableDealsDataGrid.SelectedRows[0];
            var itemID = int.Parse(row.Cells["Furniture ID"].Value.ToString());
            orderController.AddToCart(itemID, Utils.userID);
            this.loadDataGridView();
            this.loadOrderItemsGridView();
            //this.totalPriceText.Text = orderController.CalculateCartPrice(orderID).ToString();
        }
        private void availableDealsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = this.availableDealsDataGrid.Rows[e.RowIndex];
                this.itemID = int.Parse(dataGridViewRow.Cells["Furniture ID"].Value.ToString());
                
            }
        }

        private void deleteFromCartButton_Click(object sender, EventArgs e)
        {
            if(this.cartGridView.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.cartGridView.SelectedRows[0];
            this.orderController.DeleteItemFromCart(int.Parse(row.Cells["Order ID"].Value.ToString()), int.Parse(row.Cells["Furniture ID"].Value.ToString()), int.Parse(row.Cells["Order Item ID"].Value.ToString()));
            this.loadDataGridView();
            this.loadOrderItemsGridView();
            //this.totalPriceText.Text = orderController.CalculateCartPrice(orderID).ToString();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            orderID = this.orderController.GetOrderID(Utils.userID);
            string message = String.Format("Plata se poate efectua doar numerar. Totalul cosului este: {0}", this.orderController.CalculateCartPrice(orderID));
            string caption = "Confirmare comanda";
            DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.orderController.UpdateOrderStatusAfterCheckout(Utils.userID);
                this.loadDataGridView();
                this.loadOrderItemsGridView();
            }
        }
    }
}
