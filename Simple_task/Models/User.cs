using System.ComponentModel.DataAnnotations;

namespace Simple_task.Models
{
    public class User
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name does not exist")]
        public string UserName { set; get; }
    }
}
