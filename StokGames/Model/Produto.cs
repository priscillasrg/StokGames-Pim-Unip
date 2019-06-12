using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public class Produto : BaseEntidade
    {
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public string Serial { get; set; }
        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMinimo { get; set; }
        public List<EntradaSaida> EntradasSaidas { get; set; }
    }
}
