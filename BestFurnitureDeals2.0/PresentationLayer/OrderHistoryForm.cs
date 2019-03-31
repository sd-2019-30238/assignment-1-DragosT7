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
    public partial class OrderHistoryForm : Form
    {
        private OrderController orderController;
        private int id;
        private string statusorder;
        private string feedbackOrder;

        public OrderHistoryForm()
        {
            InitializeComponent();
            this.orderController = Utils.OrderController;
            this.loadOrderHistoryGridView();
        }

        public void loadOrderHistoryGridView()
        {
            this.orderHistoryDataGrid.DataSource = orderController.DisplayAllOrdersInClientDash(Utils.userID);
            this.orderHistoryDataGrid.ReadOnly = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void orderHistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = this.orderHistoryDataGrid.Rows[e.RowIndex];
                this.id = int.Parse(dataGridViewRow.Cells["Order ID"].Value.ToString());
                this.statusorder = dataGridViewRow.Cells["Order Status"].Value.ToString();
            }
        }

        private void addFeedbackButton_Click(object sender, EventArgs e)
        {
            if (this.statusorder != "ORDER DELIVERED")
            {
                string message = "Nu puteti adauga feedback la o comanda ce nu a fost livrata!";
                string caption = "Eroare la adaugarea feedback-ului";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                this.feedbackOrder = feedbackRichBox.Text;
                this.orderController.GiveFeedbackToOrder(id, feedbackOrder);
            }
            
            this.loadOrderHistoryGridView();
        }
    }
}
