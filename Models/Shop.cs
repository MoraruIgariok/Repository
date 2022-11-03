using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShopStorege.Models.Base;

namespace TopShopStorege.Models
{
    internal class Shop : BaseModel 
    {
        public string Name { get; set; }
        List<Product> GetRandomProduct { get; set; }
        List<Product> Product { get; set; }   
    }
}
