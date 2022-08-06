
using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public partial class UserDTO
    {

        public int UserId { get; set; }
        public string ? UserName { get; set; }
        public string ? FullName { get; set; }
        public string ? Password { get; set; }
        public string ? Avatar { get; set; }
        public string ? PhoneNumber { get; set; }
        public string ? Address { get; set; }
        public string ? Email { get; set; }
        public bool? Status { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreateTime { get; set; }

    }
}