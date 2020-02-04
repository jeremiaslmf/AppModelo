using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevIO.UI.Site.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno(
                "Joao da Silva",
                "email@gmail.com",
                new DateTime(1993,08,31));

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}