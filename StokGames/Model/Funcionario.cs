using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public class Funcionario : Pessoa
    {
        public string CPF { get; set; }
        public List<EntradaSaida> EntradasSaidas { get; set; }
    }
}
