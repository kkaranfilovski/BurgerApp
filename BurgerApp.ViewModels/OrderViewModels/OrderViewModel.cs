using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [Display(Name = "User")]
        [Required(ErrorMessage = "Please select user")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your location")]
        public string Location { get; set; }

        [Display(Name = "Burgers")]
        [Required(ErrorMessage = "Please select burger")]
        public List<int> BurgerId { get; set; }
    }
}
