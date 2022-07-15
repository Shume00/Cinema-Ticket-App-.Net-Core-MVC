using CinemaTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace CinemaTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is required")]
        public string CinemaLogo { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
