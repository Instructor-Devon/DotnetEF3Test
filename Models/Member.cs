using System.ComponentModel.DataAnnotations;

namespace TestingMvc.Models
{
    public class Member
    {
        [Key]
        public int Id {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
    }
}