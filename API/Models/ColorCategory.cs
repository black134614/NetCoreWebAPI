﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ColorCategory
    {
        public ColorCategory()
        {
            ProductStatus = new HashSet<ProductStatus>();
        }

        public int ColorCategoryId { get; set; }
        public string Title { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual ICollection<ProductStatus> ProductStatus { get; set; }
    }
}