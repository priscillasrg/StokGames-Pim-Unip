using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Model
{
    public enum TipoUsuario
    {
        Gerente,
        Funcionario
    }
    public class Usuario: BaseEntidade
    { 
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public TipoUsuario Tipo { get; set; }
        public Funcionario Funcionario { get; set; }     
        public string Token { get; set; }
    }
}
