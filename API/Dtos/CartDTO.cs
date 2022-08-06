using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CartDTO
    {
        public int CartId { get; set; }
        public int? ProductStatusId { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
        public bool? IsPay { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
    }
}