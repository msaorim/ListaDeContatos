using ListaDeContatos1.Data;
using ListaDeContatos1.Models;

namespace ListaDeContatos1.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDbContext _context;

        public ContatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Apagar(int id)
        {
            ContatoModel contato = GetById(id);
            _context.Contato.Remove(contato);
            _context.SaveChanges();
            return true;
        }

        public List<ContatoModel> GetAll()
        {
            return _context.Contato.ToList();
        }

        public ContatoModel GetById(int id)
        {
            return _context.Contato.FirstOrDefault(x => x.ContatoId == id);
        }

        public ContatoModel Salvar(ContatoModel contato)
        {
            _context.Contato.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModel Editar(ContatoModel contato) 
        {
            ContatoModel dados = GetById(contato.ContatoId);
            dados.Nome = contato.Nome;
            dados.Cpf = contato.Cpf;

            _context.Contato.Update(dados);
            _context.SaveChanges();

            return dados;
        }
    }
}
