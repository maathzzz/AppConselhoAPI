using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

using AppConselhoAPI.Model;
using AppConselhoAPI.View;

namespace AppConselhoAPI.Services
{
    public class DataService
    {
        public static async Task<Conselho> GetConselhoRandom()
        {
            string url = "https://api.adviceslip.com/advice/";
            dynamic resultado = await getDataFromService(url).ConfigureAwait(false);

            if (resultado["slip"] != null) 
            {
                Conselho advice = new Conselho();
                advice.slip_id = (string)resultado["slip"]["id"];
                advice.advice = (string)resultado["slip"]["advice"];

                return advice;
            }

            else
            {
                return null;
            }
        }

        public static async Task<Conselho> GetConselhoByNum(string conselho_num)
        {
            // "https://api.adviceslip.com/advice/{slip_id}" + conselho_num;
            string querystring = string.Format("https://api.adviceslip.com/advice/" + conselho_num);
            dynamic resultado = await getDataFromService(querystring).ConfigureAwait(false);

            if (resultado["slip"] != null)
            {
                Conselho advice = new Conselho();
                advice.slip_id = (string)resultado["slip"]["id"];
                advice.advice = (string)resultado["slip"]["advice"];

                return advice;
            }

            else
            {
                return null;
            }
        }

        public static async Task<dynamic> getDataFromService(string queryString)
        {
            //same
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);
            dynamic data = null;

            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}
