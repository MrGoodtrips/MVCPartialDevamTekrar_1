using MVCPartialDevamTekrar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPartialDevamTekrar_1.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Employee> Employees { get; set; }
    }
}