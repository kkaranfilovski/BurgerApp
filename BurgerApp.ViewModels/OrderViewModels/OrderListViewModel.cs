namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderListViewModel
    {
        public int OrderId { get; set; }
        public string UserFullName { get; set; }
        public List<string> Burgers { get; set; }
    }
}
