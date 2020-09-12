using LanchesLf.Repositories;
using LanchesLf.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesLf.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;


        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository CategoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = CategoriaRepository;
        }

        public IActionResult List()
        {

            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categoria";

            // var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);

          
        }
    }
}
