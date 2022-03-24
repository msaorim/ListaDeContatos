using ListaDeContatos1.Models;

namespace ListaDeContatos1.Repositories
{
    public interface IContatoRepository
    {
        List<ContatoModel> GetAll();

        ContatoModel Salvar(ContatoModel contato);

        ContatoModel GetById(int id);

        bool Apagar(int id);

        ContatoModel Editar(ContatoModel contato);
    }
}
