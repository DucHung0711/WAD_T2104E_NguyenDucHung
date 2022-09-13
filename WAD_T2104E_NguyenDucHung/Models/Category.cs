using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenDucHung.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Students { get; set; }
    }
}