using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SQLclient.Interfaces
{
    /// <summary>
    /// Generic Text repository
    /// </summary>
    public interface ITextRepository<T> where T : class
    {
        /// <summary>
        /// Gets all objects from database
        /// </summary>
        IEnumerable<T> GetAll();

        void Save();
    }
}
