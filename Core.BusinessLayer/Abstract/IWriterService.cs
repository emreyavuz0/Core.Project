using Core.EntityLayer.Concrete;

namespace Core.BusinessLayer.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
         List<Writer> GetWriterById(int id);

    }
}
