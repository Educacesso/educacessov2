using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        TEntity GetByID(string Id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
