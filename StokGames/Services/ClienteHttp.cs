using System;
using System.Net.Http;
using System.Net.Http.Headers;


namespace StokGames.Services
{
    public class ClienteHttp
    {
        private static HttpClient dashboard_api;

        public static HttpClient Get()
        {
            dashboard_api = new HttpClient();
            dashboard_api.DefaultRequestHeaders.Clear();
            dashboard_api.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            dashboard_api.BaseAddress = new Uri("https://localhost:44315");
            return dashboard_api;
        }
    }
}
