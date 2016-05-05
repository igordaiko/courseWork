using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using City_Go.DataBase;
using City_Go.Models;
using System.Data;
namespace City_Go.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ITable itable = new Categories_Reader();
            WorkWithDataBase reader = new WorkWithDataBase(itable);
            DataTable table = reader.SelectAllRows();
            HomeModel model = new HomeModel();
            model.Categories = new List<CategoriesModel>();
            CategoriesModel cat_model;
            foreach (DataRow row in table.Rows)
            {
                cat_model = new CategoriesModel();
                cat_model.ID = (int)row[0];
                cat_model.Name = (string)row[1];
                cat_model.html_id = (string)row[2];
                model.Categories.Add(cat_model);                
            }
            
            return View(model);
        }
        public ActionResult Change_Filter(string id)
        {
            ITable itable = new Filter_Reader();
            WorkWithDataBase reader = new WorkWithDataBase(itable);
            DataTable table = reader.SelectRowsByFilter(id);
            List<FilterModel> model = new List<FilterModel>();
            FilterModel filter_model;
            foreach(DataRow row in table.Rows)
            {
                filter_model = new FilterModel();
                filter_model.ID = (int)row[0];
                filter_model.Name = (string)row[1];
                filter_model.Description = (string)row[2];
                filter_model.Cat_id = (string)row[3];
                model.Add(filter_model);
            }
            ViewBag.Filters = model;
            return PartialView(model);
        }
    }
}