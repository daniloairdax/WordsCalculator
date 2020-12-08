using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.TextEntities
{
    ///<summary>
    /// Gets or sets Text.
    ///</summary>
    public class TextModel
    {
        ///<summary>
        /// Gets or sets Text model id.
        ///</summary>
        public long Id { get; set; }
        ///<summary>
        /// Gets or sets Text content.
        ///</summary>
        public string Text { get; set; }
        ///<summary>
        /// Gets or sets sum of text words.
        ///</summary>
        public int WordsCount { get; set; }
    }
}
