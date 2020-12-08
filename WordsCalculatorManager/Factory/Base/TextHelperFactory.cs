using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsCalculatorManager.Helpers.Base;

namespace WordsCalculatorManager.Factory.Base
{
    /// <summary>  
    /// The 'Factory' Abstract Class  
    /// </summary>  
    abstract class TextHelperFactory
    {
        public abstract TextHelper GetTextHelper();
    }
}
