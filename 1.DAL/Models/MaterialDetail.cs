using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class MaterialDetail
    {
        [Key]
        public Guid IdMDetail { get; set; }

        public Decimal Price { get; set; }

        public Decimal ImportPrice { get; set; }

        public int Amount { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }
        public Guid IdProducer { get; set; }
        public Producer Producer { get; set; }
        public Guid IdMaterial { get; set; }

        public Material Material { get; set; }
    }
}
