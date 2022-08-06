
using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public partial class ProductDTO
    {

        public int ProductId { get; set; }
        public string ? Title { get; set; }
        public string ? Decscription { get; set; }
        public string ? SeoDecscription { get; set; }
        public string ? Infomation { get; set; }
        public int? Price { get; set; }
        public int? SalePrice { get; set; }
        public bool? Status { get; set; }
        public string ? ProductImages { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }

    }
}