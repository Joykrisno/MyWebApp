using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }    
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   


    }


}
