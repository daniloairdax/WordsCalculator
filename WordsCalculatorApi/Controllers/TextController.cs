using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Entities.TextEntities;
using Services.ServiceContracts;

namespace WordsCalculatorApi.Controllers
{
    public class TextController : ApiController
    {
        private readonly ITextService _textService;

        public TextController(ITextService textService)
        {
            _textService = textService;
        }

        [HttpGet]
        public TextModel GetWordsCountFromDB()
        {
            var textModel = _textService.GetWordsCountFromDB();
            return textModel;
        }

        [HttpGet]
        public int GetWordsCountFromClient(string text)
        {
            var count = _textService.GetWordsCountFromClient(text);
            return count;
        }
    }
}