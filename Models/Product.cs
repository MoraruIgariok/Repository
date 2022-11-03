using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShopStorege.Models.Base;

namespace TopShopStorege.Models
{
    public class Product : BaseModel 
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
