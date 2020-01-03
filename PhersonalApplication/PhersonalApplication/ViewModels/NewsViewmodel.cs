using Newtonsoft.Json;
using PhersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace PhersonalApplication.ViewModels
{
   public class NewsViewmodel
    {
        private ObservableCollection<News> _news = new ObservableCollection<News>();

        public ObservableCollection<News> News
        {
            get
            {
                return this._news;
            }
        }

        public async void ReadNews()
        {
            try
            {
                // 33e2f5657f4b430980ff4f98f4ab54e7

                string URL = @"http://193.10.202.76/PhersonalklubbenREST/api/Nyheters";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(URL));

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var newsList = JsonConvert.DeserializeObject<List<News>>(content);

                    foreach (var item in newsList)
                    {
                        _news.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                //ToDo Give errormessage to user and possibly log error
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        public News GetNewsByID(int id)
        {
            return _news.FirstOrDefault(d => d.ID == id);
        }
    }
}
