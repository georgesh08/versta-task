using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VerstaTask.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Sender city")]
        public string SenderCity { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Sender address")]
        public string SenderAddress { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Recipient city")]
        public string RecipientCity { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Recipient address")]
        public string RecipientAddress { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Cargo weight")]
        public double CargoWeight { get; set; }
        
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Transportation date")]
        public DateTime TransportationDate { get; set; }
    }
}