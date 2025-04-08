using System.ComponentModel.DataAnnotations;

namespace ProdutosItems1.Models
{
    public class Requisicao
    {
        [Required(ErrorMessage = "Favor preecher o Número do Pedido!", AllowEmptyStrings = false)]
        public int NumeroRequisicao { get; set; }
        public IList<Contact> Itens { get; set; } = new List<Contact>();
    }
}
