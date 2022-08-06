
using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public partial class ColorCategoryDTO
    {

        public int ColorCategoryId { get; set; }
        public string ? Title { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }

    }
}