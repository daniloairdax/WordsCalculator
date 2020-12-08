using Entities.TextEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceContracts
{
    /// <summary>
    /// Text service interface.
    /// </summary>
    public interface ITextService
    {
        /// <summary>
        /// Gets first valid record from database.
        /// </summary>
        TextModel GetWordsCountFromDB();
        /// <summary>
        /// Count words from client application.
        /// </summary>
        int GetWordsCountFromClient(string text);
    }
}
