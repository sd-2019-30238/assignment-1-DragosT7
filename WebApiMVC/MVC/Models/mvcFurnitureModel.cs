using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcFurnitureModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public string namefurniture { get; set; }
        public string descriptionfurniture { get; set; }
        public string typefurniture { get; set; }
        public Nullable<double> price { get; set; }
        public string seller { get; set; }
        public Nullable<int> nrofproducts { get; set; }
    }
}