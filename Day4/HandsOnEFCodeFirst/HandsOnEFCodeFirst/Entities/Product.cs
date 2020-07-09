using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEFCodeFirst.Entities
{
    class Product
    {
        [Key]
        public int Pid { get; set; }
        [Required]
        [StringLength(30)]
        public string Pname { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        //Navigation Prop
        public ICollection<Order> Orders { get; set; }
    }
}
