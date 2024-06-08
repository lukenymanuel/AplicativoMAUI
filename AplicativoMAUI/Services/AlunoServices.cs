using AplicativoMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AplicativoMAUI.Services;
 public class AlunoService : IAlunoRepository
{
    public async Task<Aluno> ImprimirNotas(int id)
    {
        try
        {
            var client = new HttpClient();
            string localhostUrl = $"https://localhost:7011/api/aluno/{id}";
            client.BaseAddress = new Uri(localhostUrl);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                Aluno aluno = await response.Content.ReadFromJsonAsync<Aluno>();
                return aluno;
            }
            return null;
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Erro", ex.Message, "Ok");
            return null;
        }
    }
    public async Task<Aluno> GetAluno(int id)
    {
        try
        {
            var client = new HttpClient();
            string localhostUrl = $"https://localhost:7011/api/aluno/{id}";
            client.BaseAddress = new Uri(localhostUrl);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                Aluno aluno = await response.Content.ReadFromJsonAsync<Aluno>();
                return aluno;
            }
            return null;
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Erro", ex.Message, "Ok");
            return null;
        }
    }


}










