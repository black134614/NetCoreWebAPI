﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? ProductStatusId { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public bool? IsPay { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }

        public virtual User CreateByNavigation { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
    }
}