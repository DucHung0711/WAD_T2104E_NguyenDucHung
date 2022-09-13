using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenDucHung.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage = "Vui long nhap ten")]
        public string Name { get; set; }

        //[Display(Name = "Price")]
        //[Required(ErrorMessage = "Vui long nhap gia")]
        public double Price { get; set; }

        //[Display(Name = "Quantity")]
        //[Required(ErrorMessage = "Vui long nhap so luong")]
        public int Quantity { get; set; }

        //[Display(Name = "ReleaseDate")]
        //[Required(ErrorMessage = "Vui long nhap ngay")]
        public DateTime ReleaseDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}