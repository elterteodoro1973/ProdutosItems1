using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using ProdutosItems1.Models;

namespace ProdutosItems1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            Pedido pedido = new Pedido();
            pedido.NumeroPedido = 1;

            pedido.Itens = new List<ItensPedido>();
            pedido.Itens.Add(new ItensPedido { NumeroPedido = pedido.NumeroPedido, Codigo = "A001",  Produto = "Capa de cama para cachorro à prova d'água", Quantidade = 2, Valor = 52.75m });
            pedido.Itens.Add(new ItensPedido { NumeroPedido = pedido.NumeroPedido, Codigo = "B002", Produto = "Vintage cccp união soviética vostok", Quantidade = 4, Valor = 19.03m });
            pedido.Itens.Add(new ItensPedido { NumeroPedido = pedido.NumeroPedido, Codigo = "C003", Produto = "Relogio Cassio 87X", Quantidade = 7, Valor = 104.00m });
            pedido.Itens.Add(new ItensPedido { NumeroPedido = pedido.NumeroPedido, Codigo = "D004", Produto = "Medidor eletrico katurs 1007X", Quantidade = 9, Valor = 194.00m });

            return View(pedido);
        }

        [HttpPost]
        public ActionResult Index(Pedido model)
        {
            var teste = model;

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
