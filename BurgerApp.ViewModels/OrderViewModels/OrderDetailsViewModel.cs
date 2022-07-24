﻿using BurgerApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public string UserFullName { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public bool status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<string> Burgers { get; set; }
    }
}
