using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class FurnitureController : Controller
    {
        // GET: Furniture
        public ActionResult Index()
        {
            IEnumerable<mvcFurnitureModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Furniture").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcFurnitureModel>>().Result;
            return View(empList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new mvcFurnitureModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Furniture/"+id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcFurnitureModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcFurnitureModel emp)
        {
            if (emp.id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Furniture", emp).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Furniture/"+emp.id, emp).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Furniture/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");

        }
    }

    
}