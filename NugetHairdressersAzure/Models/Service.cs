﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CutAndGo.Models {

    [Table("SERVICES")]
    public class Service {
        [Column("service_id")]
        public int ServiceId { get; set; }
        
        [Column("hairdresser_id")]
        public int HairdresserId { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("price")]
        public decimal Price { get; set; }
        
        [Column("daprox")]
        public byte TiempoAprox { get; set; }
    }

}
