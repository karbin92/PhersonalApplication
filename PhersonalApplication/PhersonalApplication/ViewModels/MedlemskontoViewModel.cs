using Newtonsoft.Json;
using PhersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace PhersonalApplication.ViewModels
{
   public class MedlemskontoViewModel
    {
        public async System.Threading.Tasks.Task<bool> LoginAsync(Medlemskonto medlem)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://193.10.202.76/PhersonalklubbenREST/");

                var myContent = JsonConvert.SerializeObject(medlem);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var result = client.PostAsync("api/medlemslogin", byteContent).Result;

                string data = await result.Content.ReadAsStringAsync();

                bool success = false;
                if (result.IsSuccessStatusCode)
                {
                    success = true;
                    return success;
                }
                else
                {
                    return success;
                }
 
            }
        }
    }
}
