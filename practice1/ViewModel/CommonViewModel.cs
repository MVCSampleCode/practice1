using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using practice1.Models;

namespace practice1.ViewModel
{
    public class CommonViewModel
    {
        public List<Movie> CommonMovie { get; set; }
        public List<Customer> CommonCustomer { get; set; }
    }
}