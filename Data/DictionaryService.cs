using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HTTPClientDemo2.Models;

namespace HTTPClientDemo2.Data
{
    public class DictionaryService
    {
       public async Task<DefinitionResult> GetDefinitionAsync(string wordToDefine)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://wordsapiv1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-Mashape-Key", "1bc55635edmsh5d5800c31204366p15f03djsneb5918e71ce9");

            var response = await client.GetAsync("/words/" + wordToDefine);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            DefinitionResult definitionObject = JsonSerializer.Deserialize<DefinitionResult>(responseString);

            return definitionObject;
         
        }
    
    }
}
