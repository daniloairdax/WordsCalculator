using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsCalculatorManager.Factory.Base;
using WordsCalculatorManager.Helpers;
using WordsCalculatorManager.Helpers.Base;

namespace WordsCalculatorManager.Factory
{
    /// <summary>  
    /// A 'ConcreteFactory' class  
    /// </summary> 
    class ClientTextHelperFactory : TextHelperFactory
    {
        public override TextHelper GetTextHelper()
        {
            return new ClientTextHelper();
        }
    }
}
