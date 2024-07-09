using CAAPI.Model;

namespace CAAPI.Repository.IRepository
{
    public interface IContactRepository
    {
        //metodo para buscar todos los datos
        ICollection<Contact> GetAll();

        //metodo para buscar un contacto

        Contact Get(int id);
    }
}
