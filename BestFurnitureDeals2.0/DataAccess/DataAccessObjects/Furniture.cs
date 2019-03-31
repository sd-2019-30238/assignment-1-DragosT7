using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.DataAccess.DataAccessObjects
{
    class Furniture
    {
        private int furnitureID;
        private string nameFurniture;
        private string descriptionFurniture;
        private string typeFurniture;
        private float price;
        private string seller;
        private int numberOfProducts;

        public Furniture(string nameFurniture, string descriptionFurniture, string typeFurniture, float price, string seller, int numberOfProducts)
        {
            this.nameFurniture = nameFurniture;
            this.descriptionFurniture = descriptionFurniture;
            this.typeFurniture = typeFurniture;
            this.price = price;
            this.seller = seller;
            this.numberOfProducts = numberOfProducts;
        }

        public Furniture(int furnitureID, string nameFurniture, string descriptionFurniture, string typeFurniture, float price, string seller, int numberOfProducts)
        {
            this.furnitureID = furnitureID;
            this.nameFurniture = nameFurniture;
            this.descriptionFurniture = descriptionFurniture;
            this.typeFurniture = typeFurniture;
            this.price = price;
            this.seller = seller;
            this.numberOfProducts = numberOfProducts;
        }

        public int FurnitureID { get => furnitureID; set => furnitureID = value; }
        public string NameFurniture { get => nameFurniture; set => nameFurniture = value; }
        public string DescriptionFurniture { get => descriptionFurniture; set => descriptionFurniture = value; }
        public string TypeFurniture { get => typeFurniture; set => typeFurniture = value; }
        public float Price { get => price; set => price = value; }
        public string Seller { get => seller; set => seller = value; }
        public int NumberOfProducts { get => numberOfProducts; set => numberOfProducts = value; }
    }
}
