using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Material
    {
        [Key]
        public Guid IdMaterial { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int Status { get; set; }

        public ICollection<MaterialDetail> MaterialDetails { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
