using System.ComponentModel.DataAnnotations;

namespace WebApplication1_mvc_.Models
{
    public class Users
    {
         
            public int Id { get; set; }
            [Required(ErrorMessage ="Name is required")]
            [MinLength(3, ErrorMessage ="min length is 3")]
            [MaxLength(20, ErrorMessage ="max length is 20")]
       
            public string Name { get; set; }
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Range(20, 80)]
            public int Age { get; set; }
            [Range(10, 100)]
            public decimal Score { get; set; } 
        
    }
}
