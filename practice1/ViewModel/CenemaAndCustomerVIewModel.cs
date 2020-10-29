using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using practice1.Models;


namespace practice1.ViewModel
{
    public class CenemaAndCustomerVIewModel
    {

        public List<Cinema> CinemaVM { get; set; }
        public List<CinemaCustomers> CinemaCustomersVM { get; set; }
    }
}