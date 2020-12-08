using SQLclient.DTO;
using SQLclient.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SQLclient.Providers
{
    public class TextRepository<T> : ITextRepository<T> where T : class
    {       
        private WordsContext _dbContext = null;
        private readonly DbSet<T> _dbSet = null;

        public TextRepository()
        {
            _dbContext = new WordsContext();
            _dbSet = _dbContext.Set<T>();
        }
        public TextRepository(WordsContext wordsContext)
        {
            _dbContext = wordsContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
