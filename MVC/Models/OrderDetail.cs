﻿namespace MVC.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public ICollection<OptionDetail> OptionDetails { get; set; }
    }
}
