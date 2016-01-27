﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DasShop.Models
{
    [Serializable]
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        
    }
}