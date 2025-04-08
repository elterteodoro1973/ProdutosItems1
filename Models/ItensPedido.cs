using System.ComponentModel.DataAnnotations;

namespace ProdutosItems1.Models
{
    public class ItensPedido
    {

        public int NumeroPedido { get; set; }

        public string  Codigo { get; set; }

        public ItensPedido()
        {
            this.NumeroPedido = 0;
            this.Codigo = "";
            this.Produto = "";
            this.Quantidade = 0;
            this.Valor = 0;
        }

        [Required(ErrorMessage = "Favor preecher o Produto!", AllowEmptyStrings = true)]
        public string Produto { get; set; }

        [Required(ErrorMessage = "Favor preecher a Quantidade!", AllowEmptyStrings = true)]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Favor preecher o Valor!", AllowEmptyStrings = true)]
        public decimal Valor { get; set; }

        public IFormFile File { get; set; }
    }
}
