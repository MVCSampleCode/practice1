using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.ViewModel;
using practice1.Models;

namespace practice1.Controllers
{
    public class INOXController : Controller
    {
         static List<CinemaCustomers> CCustomer = new List<CinemaCustomers>
            {
                new CinemaCustomers { CustomerID=1,CustomerName="Dollina",MovieID=1 },
                new CinemaCustomers { CustomerID=2,CustomerName="Sagar",MovieID=1 },
                new CinemaCustomers { CustomerID=3,CustomerName="Raj",MovieID=1 },
                new CinemaCustomers { CustomerID=4,CustomerName="Ann",MovieID=2 },
                new CinemaCustomers { CustomerID=5,CustomerName="Kan",MovieID=2 },
                new CinemaCustomers { CustomerID=6,CustomerName="Jan",MovieID=2 }
            };

        static List<Cinema> CMovie = new List<Cinema>
            {
                new Cinema { Movieid=1,Moviename="Border" },
                new Cinema { Movieid=2,Moviename="Tanaji" }
            };


        // GET: INOX
        public ActionResult Index()
        {
            CenemaAndCustomerVIewModel CCommon = new CenemaAndCustomerVIewModel
            {
                CinemaVM = CMovie,
                CinemaCustomersVM = CCustomer

            };
            return View(CCommon);
        }

        public ActionResult MovieCustomer(int id)
        {
            ViewBag.MovieID = id;
            var cust = new List<CinemaCustomers>();
            cust = CCustomer.FindAll(m => m.MovieID == id);
            //CenemaAndCustomerVIewModel CCommon = new CenemaAndCustomerVIewModel
            //{
            //    CinemaVM = CMovie,
            //    CinemaCustomersVM = CCustomer

            //};
            return View(cust);
        }
    }
}