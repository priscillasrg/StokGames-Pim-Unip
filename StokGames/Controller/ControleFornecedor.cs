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
    public class ControleFornecedor
    {
        public string mensagem { get; private set; }
        public bool sucesso { get; private set; }

        private HttpClient _httpClient;

        public ControleFornecedor()
        {
            _httpClient = ClienteHttp.Get();
        }

        public List<Fornecedor> ObterTodos()
        {
            HttpResponseMessage resposta = _httpClient.GetAsync(_httpClient.BaseAddress + $"/fornecedores/").Result;

            if (resposta.IsSuccessStatusCode)
                return resposta.Content.ReadAsAsync<List<Fornecedor>>().Result;
            else
                return null;
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + $"/fornecedores/", fornecedor).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Fornecedor cadastrado com sucesso.";
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
                mensagem = "Não foi possível cadastrar o fornecedor.";

        }

        public void EditarFornecedor(Fornecedor fornecedor)
        {
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/fornecedores/", fornecedor).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Fornecedor atualizado com sucesso.";
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
                mensagem = "Não foi possível atualizar o Fornecedor.";


        }

        public void ExcluirFornecedor(int id)
        {                    

            sucesso = false;
            HttpResponseMessage resposta = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/fornecedores/{id}").Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Fornecedor removido com sucesso.";
            }
            else
                mensagem = "Não foi possível remover o fornecedor.";


        }




    }
}
