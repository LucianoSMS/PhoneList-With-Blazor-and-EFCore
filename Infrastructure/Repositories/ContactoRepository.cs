using CsvHelper;
using CsvHelper.Configuration;
using Domain.Abstractions;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    public class ContactoRepository : IContactoRepository
    {
        private readonly SystemContext _context;
        public Contacto Contact { get; private set; }  
        public ContactoRepository(SystemContext systemContext) {
            _context = systemContext;
        }

        public async Task<Contacto> AddContact(Contacto Contact)
        {
            if (_context is not null && Contact is not null && _context.Contactos is not null)
            {
                _context.Contactos.Add(Contact);
                await _context.SaveChangesAsync();
                return Contact;
            }
            else
            {
                throw new InvalidOperationException( "Dados Invalidos");
            }
        }

        public async Task UpdateContact(Contacto contact) 
        {
            if(contact is not null) 
            { 
                _context.Entry(contact).State=EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados Invalidos");
            }
        }
        public async Task DeleteContact(int id) 
        {
            var contact = await GetContactById ( id);
            if (contact is not null)
            {
                _context.Contactos.Remove(contact);
                await _context.SaveChangesAsync();
            }
        
        }

        public async Task<IEnumerable<Contacto>> GetAllContacts()
        {
            if (_context is not null && _context.Contactos is not null) 
            {
                var contacts = await _context.Contactos.ToListAsync();
                return contacts;
            }
            else
            {
                return new List<Contacto> ();
            }
        }

        public async Task <Contacto> GetContactById(int id)
        {
            var contact= await _context.Contactos.FirstOrDefaultAsync(i=>i.Id==id);
            if (contact is null)
            {
                throw new InvalidOperationException("Dados Invalidos");

            }
            else
            {
                return contact;
            }
        }

            }
}
