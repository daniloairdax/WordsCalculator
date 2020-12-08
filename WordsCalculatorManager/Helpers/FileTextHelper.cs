using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WordsCalculatorManager.Helpers.Base;

namespace WordsCalculatorManager.Helpers
{
    /// <summary>  
    /// A 'Concrete' TextHelper class 
    /// </summary>
    class FileTextHelper : TextHelper
    {
        private readonly string _textHelperType;

        public FileTextHelper()
        {
            _textHelperType = "File";
        }

        public override string TextHelperType
        {
            get { return _textHelperType; }
        }
        public override int GetWordsCountFromClient(string text)
        {
            try
            {
                var count = 0;
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:44374/Text/GetWordsCountFromClient?Text=" + text;
                    var result = client.GetAsync(url).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        count = int.Parse(result.Content.ReadAsStringAsync().Result);
                    }                  
                }
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
