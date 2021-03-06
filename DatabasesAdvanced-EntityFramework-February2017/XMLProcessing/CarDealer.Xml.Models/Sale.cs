﻿namespace CarDealer.Xml.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Sale
    {
        public int Id { get; set; }

        public decimal Discount { get; set; }

        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
