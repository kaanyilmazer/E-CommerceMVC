using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace vizem.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public String Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}