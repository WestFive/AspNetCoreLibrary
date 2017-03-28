using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Simple.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
