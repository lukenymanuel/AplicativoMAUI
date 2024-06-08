using AplicativoMAUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AplicativoMAUI.Services
{
    class LoginService : ILoginRepository
    {
        public async Task<Aluno> Login (string username, string password)
        {
            try
            {
                var client = new HttpClient();
                string Url = "https://localhost:7011/login?username=" + username + "&password=" + password ;
                client.BaseAddress = new Uri(Url);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    Aluno aluno = JsonConvert.DeserializeObject<Aluno>(content);
                    return await Task.FromResult(aluno);
                }
                return null;
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
                return null;
            }
           
        }
    }
}
