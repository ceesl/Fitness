using System;

namespace Fitness.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string ToestelNaam { get; set; }
        public string Description { get; set; }
        public double Gewicht { get; set; }
        public int Herhaling { get; set; }
        public int Series { get; set; }
    }
}