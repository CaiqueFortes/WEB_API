using Business.InterfaceProduto;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ProdutoRepositorio
{
    public class RepositorioProduto : RepositoryGenerics<ProductViewModel>, IProduto
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioProduto()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
