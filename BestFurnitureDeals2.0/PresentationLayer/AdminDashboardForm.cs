using BestFurnitureDeals2._0.BusinessLogic;
using BestFurnitureDeals2._0.BusinessLogic.Factory;
using BestFurnitureDeals2._0.Commons;
using BestFurnitureDeals2._0.DataAccess.DataAccessObjects;
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
    public partial class AdminDashboardForm : Form
    {
        private FurnitureController furnitureController;
        private OrderController orderController;
        int id;
        int furnitureID;
        private string statusOrder;
        private int discountOrder;

        public AdminDashboardForm()
        {
            InitializeComponent();
            this.furnitureController = Utils.FurnitureController;
            this.orderController = Utils.OrderController;
            this.loadDataGridView();
            this.loadOrdersGridView();
            this.statusComboBox.Items.Add(orderController.RetrieveStatusProcessing);
            this.statusComboBox.Items.Add(orderController.RetrieveStatusDelivering);
            this.statusComboBox.Items.Add(orderController.RetrieveStatusDelivered);
            this.discountComboBox.Items.Add(5.ToString());
            this.discountComboBox.Items.Add(10.ToString());
            this.discountComboBox.Items.Add(15.ToString());
        }

        private void loadDataGridView()
        {
            this.furnitureGridView.DataSource = furnitureController.DisplayAllFurniture();
            this.furnitureGridView.ReadOnly = true;
        }

        private void loadOrdersGridView()
        {
            this.ordersGridView.DataSource = orderController.DisplayAllOrdersInAdminDash();
            this.furnitureGridView.ReadOnly = true;
        }

        private void furnitureGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = this.furnitureGridView.Rows[e.RowIndex];
                this.furnitureID = int.Parse(dataGridViewRow.Cells["Furniture ID"].Value.ToString());
                this.nameFurnitureText.Text = dataGridViewRow.Cells["Furniture Name"].Value.ToString();
                this.descriptionFurnitureRichBox.Text = dataGridViewRow.Cells["Description"].Value.ToString();
                this.typeFurnitureText.Text = dataGridViewRow.Cells["Type of Furniture"].Value.ToString();
                this.priceFurnitureText.Text = dataGridViewRow.Cells["Price"].Value.ToString();
                this.sellerFurnitureText.Text = dataGridViewRow.Cells["Seller"].Value.ToString();
                this.numberProductsFurnitureText.Text = dataGridViewRow.Cells["Number of products"].Value.ToString();
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var prevFrom = Utils.PrevForm;
            prevFrom.Show();
            
        }

        private void addFurnitureButton_Click(object sender, EventArgs e)
        {
            var nameFurniture = this.nameFurnitureText.Text;
            var descriptionFurniture = this.descriptionFurnitureRichBox.Text;
            var typeFurniture = this.typeFurnitureText.Text;
            var price = float.Parse(this.priceFurnitureText.Text);
            var seller = this.sellerFurnitureText.Text;
            var nrOfProducts = int.Parse(this.numberProductsFurnitureText.Text);

            Furniture furniture = new Furniture(nameFurniture, descriptionFurniture, typeFurniture, price, seller, nrOfProducts);
            this.furnitureController.CreateFurniture(furniture);
            this.loadDataGridView();
        }

        private void updateFurnitureButton_Click(object sender, EventArgs e)
        {
            var nameFurniture = this.nameFurnitureText.Text;
            var descriptionFurniture = this.descriptionFurnitureRichBox.Text;
            var typeFurniture = this.typeFurnitureText.Text;
            var price = float.Parse(this.priceFurnitureText.Text);
            var seller = this.sellerFurnitureText.Text;
            var nrOfProducts = int.Parse(this.numberProductsFurnitureText.Text);

            Furniture furniture = new Furniture(this.furnitureID, nameFurniture, descriptionFurniture, typeFurniture, price, seller, nrOfProducts);
            this.furnitureController.UpdateFurniture(furniture);
            this.loadDataGridView();
        }

        private void deleteFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureController.DeleteFurniture(this.furnitureID);
            this.loadDataGridView();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusOrder = this.statusComboBox.SelectedItem.ToString();

        }

        private void updateOrderStatusButton_Click(object sender, EventArgs e)
        {
            this.orderController.UpdateOrderStatusByAdmin(statusOrder, id);
            this.loadOrdersGridView();
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = this.ordersGridView.Rows[e.RowIndex];
                this.id = int.Parse(dataGridViewRow.Cells["Order Number"].Value.ToString());
                this.statusOrder = dataGridViewRow.Cells["Order Status"].Value.ToString();
            }
        }

        private void discountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountOrder = int.Parse(this.discountComboBox.SelectedItem.ToString());
        }

        private void applyDiscountButton_Click(object sender, EventArgs e)
        {
            // discountOrder este un int -> il voi folosi in acel switch de la factory
            var typeDiscount = DealServiceFactory.GetDeal(discountOrder);
            Console.WriteLine(typeDiscount);
            var newPrice = typeDiscount.ComputeDeal(orderController.GetTotalPriceFromOrderID(id));
            Console.WriteLine(newPrice);
            this.orderController.UpdateTotalPriceAfterDiscount(newPrice, id);
            this.loadOrdersGridView();
        }
    }
}

