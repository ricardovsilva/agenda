using System.Data.Entity;

namespace Agenda.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }
    }
}
