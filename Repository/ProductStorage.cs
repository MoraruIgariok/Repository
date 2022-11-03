using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShopStorege.Models.Base;

namespace TopShopStorege.Repository
{
    public class ProductStorage
    {
        public Guid Id { get; set; }        
        public int Count { get; set; }
    }
}
