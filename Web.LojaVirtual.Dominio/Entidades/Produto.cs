using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }//Atalho prop
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}
