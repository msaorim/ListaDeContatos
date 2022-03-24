using ListaDeContatos1.Models;
using ListaDeContatos1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeContatos1.Controllers
{

    public class ListaController : Controller
    {
        // injetar repositório
        private readonly IContatoRepository _repository;

        public ListaController(IContatoRepository repository)
        {
            _repository = repository;
        }
        //====================


        // Lista de Contatos
        public IActionResult Index()
        {
            List<ContatoModel> lista = _repository.GetAll();
            return View(lista);
        }
        //===================


        // Mostrar a tela de cadastro
        public IActionResult Criar()
        {
            return View();
        }
        //===================


        // Salvar um contato
        [HttpPost]
        public IActionResult Salvar(ContatoModel contato)
        {
            _repository.Salvar(contato);
            return RedirectToAction("Index");
        }
        //==================

        //Apagar Contato por Id
        public IActionResult Apagar(int id)
        {
            _repository.Apagar(id);
            return RedirectToAction("Index");
        }
        //=================


        // Editar um Contato
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _repository.GetById(id);
            return View(contato);
        }
        //=================


        // Salvar Alterações de um Contato
        [HttpPost]
        public IActionResult Atualizar(ContatoModel contato)
        {
            _repository.Editar(contato);
            return RedirectToAction("Index");
        }
        //=================

    }
}
