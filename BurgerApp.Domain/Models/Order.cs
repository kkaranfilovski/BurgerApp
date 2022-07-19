using BurgerApp.Domain.Enums;

namespace BurgerApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public bool IsDelivered { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<BurgerOrder> BurgerOrders { get; set; }
    }
}
