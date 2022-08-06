using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public partial class ProductStatusDTO
    {

        public int ProductStatusId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductSizeCategoryId { get; set; }
        public int? ColorCategoryId { get; set; }
        public int? Quantity { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}