
﻿using Microsoft.EntityFrameworkCore;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [StringLength(1000)]
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
