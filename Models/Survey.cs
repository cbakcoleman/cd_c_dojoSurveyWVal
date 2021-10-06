using System.ComponentModel.DataAnnotations;

namespace cd_c_dojoSurveyWValidation.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "You must enter a name.")]
        [MinLength(2, ErrorMessage = "Name can not be less than two characters.")]
        [Display(Name = "Your Name:")]
        public string name {get;set;}

        [Required(ErrorMessage = "You must select a location.")]
        [Display(Name = "Location:")]
        public string location {get;set;}

        [Required(ErrorMessage = "You must select a language.")]
        [Display(Name = "Language:")]
        public string language {get;set;}

        [MaxLength(20, ErrorMessage = "Message can not be longer than 20 characters.")]
        [Display(Name = "Comments:")]
        public string comments {get;set;}
    }
}