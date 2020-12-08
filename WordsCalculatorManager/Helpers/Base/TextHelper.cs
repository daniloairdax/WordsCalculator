using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCalculatorManager.Helpers.Base
{
    /// <summary>  
    /// TextHelper abstract class 
    /// </summary>
    abstract class TextHelper
    {
        /// <summary>  
        /// TextHelper type. 
        /// </summary>
        public abstract string TextHelperType { get; }
        /// <summary>  
        /// Count words from client application. 
        /// </summary>
        public abstract int GetWordsCountFromClient(string text);
    }
}
