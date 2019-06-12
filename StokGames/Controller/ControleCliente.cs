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
    public class ControleCliente
    {
     
        public string mensagem { get; private set; }    
        public bool sucesso { get; private set; }

        private HttpClient _httpClient; 

        public ControleCliente()
        {
            _httpClient = ClienteHttp.Get();
        }

        public List<Cliente> ObterTodos()
        {
            HttpResponseMessage resposta = _httpClient.GetAsync(_httpClient.BaseAddress + $"/clientes/").Result;

            if (resposta.IsSuccessStatusCode)
                return resposta.Content.ReadAsAsync<List<Cliente>>().Result;
            else
                return null;
        }

        public void CadastrarCliente (Cliente cliente)
        {
            #region Anterior
            //HttpResponseMessage resposta = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + $"/cliente/", cliente).Result;

            //if (resposta.IsSuccessStatusCode)    
            //    mensagem = "Cliente cadastrado com sucesso";            
            //else            
            //    mensagem = "Não foi possível realizar o cadastro";
            #endregion


            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + $"/clientes/", cliente).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Cliente cadastrado com sucesso.";
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
                mensagem = "Não foi possível cadastrar o cliente.";

        }

        public void EditarCliente(Cliente cliente)
        {
            #region Anterior
            //HttpResponseMessage resposta = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/cliente/", cliente).Result;
            //if (resposta.IsSuccessStatusCode)           
            //    mensagem = "Cliente atualizado com sucesso";            
            //else            
            //    mensagem = "Não foi possível atualizar o cadastro";
            #endregion

            sucesso = false;
            mensagem = "";
            HttpResponseMessage resposta = _httpClient.PutAsJsonAsync(_httpClient.BaseAddress + $"/clientes/", cliente).Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Cliente atualizado com sucesso.";
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
                mensagem = "Não foi possível atualizar o cliente.";


        }

        public void ExcluirCliente(int id)
        {
            #region Anterior
            //HttpResponseMessage responseGetById = _httpClient.GetAsync(_httpClient.BaseAddress + $"/cliente/{id}").Result;                         

            //if (responseGetById.IsSuccessStatusCode)                
            //    mensagem = "Cliente não existe";            


            //HttpResponseMessage responseRemove = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/cliente/{id}").Result;

            //if (responseRemove.IsSuccessStatusCode)       
            //  mensagem = "Não foi possível remover o cliente";            
            //else            
            //    mensagem = "Cliente removido com sucesso";  
            #endregion

            sucesso = false;
            HttpResponseMessage resposta = _httpClient.DeleteAsync(_httpClient.BaseAddress + $"/clientes/{id}").Result;

            if (resposta.IsSuccessStatusCode)
            {
                sucesso = true;
                mensagem = "Cliente removido com sucesso.";
            }
            else
                mensagem = "Não foi possível remover o cliente.";


        }
            
                     


    }
}
