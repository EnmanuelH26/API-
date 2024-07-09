using CAAPI.Data;
using CAAPI.Model;
using CAAPI.Repository.IRepository;

namespace CAAPI.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDataBd _db;
        public ContactRepository(ApplicationDataBd db)
        {
            _db = db;
        }

        public Contact Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Contact> GetAll()
        {
            return _db.contact.OrderBy(c => c.idContact).ToList();
        }
    }
}

