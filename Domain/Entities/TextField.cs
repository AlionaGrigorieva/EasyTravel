using System.ComponentModel.DataAnnotations;

namespace TravelCompany.Domain.Entities
{

    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Title")]
        public override string Title { get; set; } = "Info";

        [Display(Name = "Content")]
        public override string Text { get; set; } = "Content is field by the author";
    }
}
