using Domain.Entities;


namespace Domain.Abstractions
{
    public interface IContactoRepository
    {
        Task <IEnumerable<Contacto>> GetAllContacts ();
        Task<Contacto> GetContactById (int id);

        Task <Contacto> AddContact(Contacto contacto);

        Task UpdateContact(Contacto contacto);

        Task DeleteContact(int id);
    }
}
