using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
    public interface IResultServiceRepository<TEntity>
    {
        IResult Add(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(TEntity entity);

        IDataResult<List<TEntity>> GetAll();
        IDataResult<TEntity> GetById(int id);
    }
}
