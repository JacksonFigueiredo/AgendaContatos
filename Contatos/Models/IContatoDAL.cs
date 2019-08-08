using System.Collections.Generic;

namespace AgendaContatos.Models
{
    public interface IContatosDAL
    {
        IEnumerable<Contato> GetAllContatos();
        void AddContato(Contato contato);
        void UpdateContato(Contato contato);
        Contato GetContato(int? id);
        void DeleteContato(int? id);
    }
}
