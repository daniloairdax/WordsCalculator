using Entities.TextEntities;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace WordsCalculatorManager.Helpers
{
    public static class DBTextHelper
    {
        public static TextModel GetWordsCountFromDB()
        {
            try
            {
                TextModel textModel = null;
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:44374/Text/GetWordsCountFromDB";
                    var result = client.GetAsync(url).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        textModel = JsonConvert.DeserializeObject<TextModel>(result.Content.ReadAsStringAsync().Result);
                    }
                }
                return textModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        
    }
}
