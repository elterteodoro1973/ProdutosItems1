using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ProdutosItems1.Models
{
    public class Pedido
    {
        [Required(ErrorMessage = "Favor preecher o Número do Pedido!", AllowEmptyStrings = false)]
        public int NumeroPedido { get; set; }
        public IList<ItensPedido> Itens { get; set; } = new List<ItensPedido>();

    }
}
