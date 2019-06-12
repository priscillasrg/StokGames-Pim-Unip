using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public class Cliente: Pessoa
    {
 
            public string CPF { get; set; }

            public List<Saida> Saidas { get; set; }
        


    }
}
