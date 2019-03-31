using BestFurnitureDeals2._0.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFurnitureDeals2._0.Commons
{
    class Utils
    {
        public static int userID;
        private static Form prevForm;
        private static UserController userController;
        private static FurnitureController furnitureController;
        private static OrderController orderController;

        public static UserController UserController {
            get {
                if (userController == null)
                {
                    userController = new UserController();
                }
                return userController;
            }
            set
            {
                userController = value;
            }

        }

        public static FurnitureController FurnitureController
        {
            get
            {
                if (furnitureController == null)
                {
                    furnitureController = new FurnitureController();
                }
                return furnitureController;
            }
            set
            {
                furnitureController = value;
            }
        }

        public static OrderController OrderController
        {
            get
            {
                if (orderController == null)
                {
                    orderController = new OrderController();
                }
                return orderController;
            }
            set
            {
                orderController = value;
            }
        }

        public static Form PrevForm
        {
            get
            {
                return prevForm;
            }
            set
            {
                prevForm = value;
            }
        }
    }
}
