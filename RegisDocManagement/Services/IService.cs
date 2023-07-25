using RegisDocManagement.Entities;

namespace RegisDocManagement.Services
{
    public interface IService
    {
        public string AuthorizeUser(User u);
        public Task AddNewDomain(Domain d);
    }
}
