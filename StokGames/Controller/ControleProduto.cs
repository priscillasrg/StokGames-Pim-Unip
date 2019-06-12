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
    public class ControleProduto
    {              
        public string mensagem { get; private set; }
        public bool sucesso { get; private set; }

        private HttpClient _httpClient;

        public ControleProduto()
        {
            _httpClient = ClienteHttp.Get();
        }

        public List<Produto> ObterTodos()
        {
            HttpResponseMessage resposta = _httpClient.GetAsync(_httpClient.BaseAddress + $"/produtos/").Result;

            if (resposta.IsSuccessStatusCode)
                return resposta.Content.ReadAsAsync<List<Produto>>().Result;
            else
                return null;
        }

        public void CadastrarProduto(Produto produto)
        {
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + $"/produtos/", produto).Result;
               

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Produto cadastrado com sucesso.";
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
                mensagem = "Não foi possível cadastrar o Produto.";

        }

        public void EditarProduto(Produto produto)
        {
            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/produtos/", produto).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Produto atualizado com sucesso.";
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
                mensagem = "Não foi possível atualizar o produto.";


        }

        public void ExcluirProduto(int id)
        {

            sucesso = false;
            HttpResponseMessage resposta = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/produtos/{id}").Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Produto removido com sucesso.";
            }
            else
                mensagem = "Não foi possível remover o produto.";


        }

    }
}
