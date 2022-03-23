using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Data
{
   public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double TravelledDistance { get; set; }
        public ICollection<PartCar> PartCars { get; set; }
    }
}
