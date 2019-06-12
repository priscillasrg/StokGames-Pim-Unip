using StokGames.Model;
using StokGames.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StokGames.Controller
{
    public class ControleFuncionario
    {
        public string mensagem { get; private set; }
        public bool sucesso { get; private set; }

        private HttpClient _httpClient;

        public ControleFuncionario()
        {
            _httpClient = ClienteHttp.Get();
        }

        public List<Funcionario> ObterTodos()
        {
            HttpResponseMessage resposta = _httpClient.GetAsync(_httpClient.BaseAddress + $"/funcionarios/").Result;

            if (resposta.IsSuccessStatusCode)
                return resposta.Content.ReadAsAsync<List<Funcionario>>().Result;
            else
                return null;
        }


        public void CadastrarFuncionario(Funcionario funcionario)
        {
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + $"/funcionarios/", funcionario).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Funcionário cadastrado com sucesso.";
            }
            else if (resposta.StatusCode == HttpStatusCode.BadRequest)
            {
                Dictionary<string, IEnumerable<string>> inputs = resposta.Content.ReadAsAsync<Dictionary<string, IEnumerable<string>>>().Result;
                foreach (var key in inputs.Keys)
                {
                    foreach (var erro in inputs[key])
                    {
                        mensagem += erro + "\n";
                    }
                }
            }
            else
                mensagem = "Não foi possível cadastrar o funcionário.";
        }

        public void EditarFuncionario(Funcionario funcionario)
        {      
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/funcionarios/", funcionario).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Funcionário atualizado com sucesso.";
            }
            else if (resposta.StatusCode == HttpStatusCode.BadRequest)
            {
                Dictionary<string, IEnumerable<string>> inputs = resposta.Content.ReadAsAsync<Dictionary<string, IEnumerable<string>>>().Result;
                foreach (var key in inputs.Keys)
                {
                    foreach (var erro in inputs[key])
                    {
                        mensagem += erro + "\n";
                    }
                }
            }
            else
                mensagem = "Não foi possível atualizar o funcionário.";
        }

        public void ExcluirFuncionario(int id)
        {
            sucesso = false;
            HttpResponseMessage resposta = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/funcionarios/{id}").Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Funcionário removido com sucesso.";
            }
            else
                mensagem = "Não foi possível remover o funcionário.";


        }






    }
}
