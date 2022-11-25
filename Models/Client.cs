using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopShopStorege.Models.Base
{
    public class Client : BaseModel
    {
        [StringLength(25)]
        public string Name { get; set; }


        
        [StringLength(50)]  
        public int PhoneNumber { get; set; }


        [StringLength(50)]
        public string Email { get; set; }
    }
}
