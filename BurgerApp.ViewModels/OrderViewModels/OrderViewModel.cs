using BurgerApp.Domain.Enums;
using BurgerApp.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select user")]
        public int UserId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select payment method")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "Please select burger")]
        public List<int> BurgerId { get; set; }

        public List<BurgerOrder> BurgerOrders { get; set; } = new List<BurgerOrder>();

        [Display(Name = "Check if the order is delivered")]
        public bool IsDelivered { get; set; }
    }
}
