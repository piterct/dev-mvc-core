using Dev.UI.Site.Data;
using Dev.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dev.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public OperacaoService OperacaoService { get; set; }
        public OperacaoService OperacaoService2 { get; set; }


        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}
        public IActionResult IndexTeste([FromServices] IPedidoRepository _pedidoRepository)
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View();
        }

        public string Index()
        {
            return
                "Primeira instância: " + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                  "Segunda instância: " + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
        }
    }
}
