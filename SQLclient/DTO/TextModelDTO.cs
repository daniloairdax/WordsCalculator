using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SQLclient.DTO
{
    ///<summary>
    /// Gets or sets Text.
    ///</summary>
    public class TextModelDTO
    {
        ///<summary>
        /// Text id.
        ///</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        ///<summary>
        /// Text content.
        ///</summary>
        public string Text { get; set; }
    }
}