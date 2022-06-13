using Entities.Concrete;
using ProjectCore.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
