using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductCategoryDTO
    {
        public int ProductCategoryId { get; set; }
        public string ? Title { get; set; }
        public bool? Status { get; set; }
        public string ? Image { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Position { get; set; }
    }
}