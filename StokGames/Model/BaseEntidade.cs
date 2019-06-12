using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public enum Status
    {
        Inativo,
        Ativo,
        Pendente
    }

    public class BaseEntidade
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }
    }
}
