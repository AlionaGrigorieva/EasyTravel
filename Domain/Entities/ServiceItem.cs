using System.ComponentModel.DataAnnotations;

namespace TravelCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Please, fill the title of service")]
        [Display(Name = "Service title")]
        public override string Title { get; set; }

        [Display(Name = "Service subtitle")]
        public override string Subtitle { get; set; }

        [Display(Name = "Service description")]
        public override string Text { get; set; }
    }
}
