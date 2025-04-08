using System.ComponentModel.DataAnnotations;

namespace ProdutosItems1.Models
{
    public class Contact
    {
        [Required]
        public int NumeroRequisicao { get; set; }


        [Required]
        public int ContactID { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string Contactno { get; set; }
        public string EmailID { get; set; }
    }
}
