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
   public class MedlemViewModel
    {
        private ObservableCollection<Medlemmar> _members = new ObservableCollection<Medlemmar>();

        public ObservableCollection<Medlemmar> Members
        {
            get
            {
                return this._members;
            }
        }

        public async void ReadMembers()
        {
            try
            {
                // 33e2f5657f4b430980ff4f98f4ab54e7

                string URL = @"http://193.10.202.76/PhersonalklubbenREST/api/Medlemmars";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(URL));

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var newsList = JsonConvert.DeserializeObject<List<Medlemmar>>(content);

                    foreach (var item in newsList)
                    {
                        _members.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        public Medlemmar GetMemberByID(int id)
        {
            return _members.FirstOrDefault(d => d.ID == id);
        }

    }
}
