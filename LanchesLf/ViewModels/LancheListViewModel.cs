using System;
using System.Collections.Generic;
using LanchesLf.Models;

namespace LanchesLf.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
