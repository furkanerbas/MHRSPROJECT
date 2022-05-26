using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Models
{
    public class Base<T>
    {
        [Key] //PK
        [Column(Order = 1)] // 1. kolon
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // identity ve bire birer artsın diye
        public T Id { get; set; }

        [DataType(DataType.DateTime)] // Bunun dakika ve saniye de tutmasını istiyorum
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }

}
