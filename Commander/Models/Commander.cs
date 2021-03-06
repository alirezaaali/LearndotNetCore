using System;
using System.Security.AccessControl;
namespace Models
{
    public class Command : object
    {
        public Command() : base()
        {

        }


        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Line { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MaxLength(length: 250)]
        public string HowTo { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Platform { get; set; }
    }
}