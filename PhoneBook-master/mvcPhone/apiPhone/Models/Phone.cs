
//api
namespace apiPhone.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum ContactType
    {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN,
        Discord
    }

    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ContactType Type { get; set; }
        [Required]
        public string Contact { get; set; }

    }
}