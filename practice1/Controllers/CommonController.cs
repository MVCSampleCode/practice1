using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;

namespace practice1.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Index()
        {
            var movie = new List<Models.Movie> {
                new Models.Movie {  ID = 1, MovieName = "Titanic" },
                new Models.Movie {  ID = 2, MovieName = "Border" },


            };
            var customer = new List<Models.Customer>
            {   
                new  Models.Customer { CustID = 1, CustName = "Dollina", CustMovieID=1 },
                new  Models.Customer { CustID = 2, CustName = "Swapnil", CustMovieID=1 },
                new  Models.Customer { CustID = 3, CustName = "Sagar", CustMovieID=1 },
                new  Models.Customer { CustID = 4, CustName = "Anil", CustMovieID=2 },
                new  Models.Customer { CustID = 5, CustName = "ann", CustMovieID=2 },
                new  Models.Customer { CustID = 6, CustName = "joe", CustMovieID=2 }


                };

            var common = new practice1.ViewModel.CommonViewModel
            {
                CommonCustomer = customer,
                CommonMovie = movie

            };

            
            return View(common);
        }

        

        public ActionResult Movie(int ID)
        {

            var customer = new List<Models.Customer>
            {
                new  Models.Customer { CustID = 1, CustName = "Dollina", CustMovieID=1 },
                new  Models.Customer { CustID = 2, CustName = "Swapnil", CustMovieID=1 },
                new  Models.Customer { CustID = 3, CustName = "Sagar", CustMovieID=1 },
                new  Models.Customer { CustID = 4, CustName = "Anil", CustMovieID=2 },
                new  Models.Customer { CustID = 5, CustName = "ann", CustMovieID=2 },
                new  Models.Customer { CustID = 6, CustName = "joe", CustMovieID=2 }


                };


            //var common = new practice1.ViewModel.CommonViewModel
            //{
            //     CommonCustomer  = customer

            //};
            @ViewBag.ID = ID;

            return View(customer);
        }


        public ActionResult Customer()
        {
            //var movie = new Models.Movie { ID = 1, MovieName = "Titanic" };
            //var customer = new Models.Customer {
            //      CustID = 1, CustName = "Dollina" }  
            //     ;

            //var common = new practice1.ViewModel.CommonViewModel
            //{
            //    CommonCustomer = customer 

            //};


            return View();
        }
        
    }
}