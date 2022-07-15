using CinemaTickets.Data.Base;
using CinemaTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Poster is required")]
        [Display(Name = "Poster")]
        public string PosterImage { get; set; }
        [Required(ErrorMessage = "Starting Date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Ending Date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Select Category")]
        public MovieCategory MovieCategory { get; set; }
        [Required(ErrorMessage = "Actors are required")]
        [Display(Name = "Select Actors")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Cinemas are required")]
        [Display(Name = "Select Cinemas")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Producer is required")]
        [Display(Name = "Select Producer")]
        public int ProducerId { get; set; }

    }
}
