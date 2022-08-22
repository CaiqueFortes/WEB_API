using Business.InterfaceProduto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Product;

namespace API_WEB_3Camadas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IProduto _IProduto;

        public ProdutosController(IProduto IProduto)
        {
            _IProduto = IProduto;
        }

        [HttpGet("ListarProdutos")]
        public async Task<IActionResult> ListarProdutos()
        {
            return Json(await _IProduto.List());
        }
        [HttpPost("ObterProdutoPorId")]
        public async Task<IActionResult> ObterProdutoPorId(int Id)
        {
            return Json(await _IProduto.GetEntityById(Id));
        }
        [HttpPost("AdicionarProduto")]
        public async Task AdicionarProduto(ProductViewModel product)
        {
            await _IProduto.Add(product);
        }
        [HttpPost("AtualizarProduto")]
        public async Task AtualizarProduto(ProductViewModel product)
        {
            await _IProduto.Update(product);
        }
        [HttpPost("RemoverProduto")]
        public async Task RemoverProduto(ProductViewModel product)
        {
            await _IProduto.Delete(product);
        }
    }
}
