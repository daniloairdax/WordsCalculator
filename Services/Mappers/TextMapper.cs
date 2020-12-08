using Entities.TextEntities;
using SQLclient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers
{
    /// <summary>
    /// Text database object to Text model mapper.
    /// </summary>
    public static class TextMapper
    {
        /// <summary>
        /// Converts Text database object to Text model.
        /// </summary>
        public static TextModel ToTextObject(TextModelDTO textModelDto)
        {
            TextModel textModel = null;

            if (textModelDto == null) {
                textModel = new TextModel
                {
                    Id = -1,
                    Text = "Exception: Load from database failed or there is no record.",
                    WordsCount = 0
                };
            }
            else
            {
                textModel = new TextModel
                {
                    Id = textModelDto.Id,
                    Text = textModelDto.Text,
                    WordsCount = 0
                };
            }

            return textModel;
        }
    }
}
