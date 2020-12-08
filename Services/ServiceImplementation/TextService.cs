using Entities.TextEntities;
using Services.Helpers;
using Services.ServiceContracts;
using SQLclient.DTO;
using SQLclient.Interfaces;
using Services.Mappers;
using SQLclient.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.ServiceImplementation
{
    public class TextService : ITextService
    {
        private readonly ITextRepository<TextModelDTO> _textRepository;

        public TextService()
        {
            _textRepository = new TextRepository<TextModelDTO>();
        }

        public TextService(ITextRepository<TextModelDTO> textRepository)
        {
            _textRepository = textRepository;
        }
        public TextModel GetWordsCountFromDB()
        {
            try
            {
                var models = _textRepository.GetAll();
                var model = models.FirstOrDefault(x => x.Text.ToString().Length > 0);
                var textModel = TextMapper.ToTextObject(model);

                if (textModel != null && textModel.Id != -1)
                {
                    textModel.WordsCount = TextHelper.CountWordsFromText(textModel.Text);
                }              
                return textModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetWordsCountFromClient(string text)
        {
            try
            {
                var count = TextHelper.CountWordsFromText(text);
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }                 
    }
}
