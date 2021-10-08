using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Controllers
{
    [Route("Professor")]
    public class ProfessorController : Controller
    {
        Professor ProfessorModel = new Professor();
        private object professorModel;

        public IActionResult Index()
        {
            ViewBag.ListaDeProfessores = ProfessorModel.ListarProfessor();
            return View();
        }

        [Route("CadastroProf")]
        public IActionResult CadastroProf()
        {
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formulario)
        {

            Professor professor = new Professor();

            professor.Nome = formulario["professorNome"];
            professor.Email = formulario["professorEmail"];
            professor.Telefone = formulario["professorTel"];
            professor.Endereco = formulario["professorEnd"];
            professor.Cargo = formulario["professorCargo"];

            professor.CadastrarProfessor(professor);

            return LocalRedirect("/");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Professor professor = new Professor();

            professor.Id = int.Parse(formulario["professorId"]);
            professor.Nome = formulario["professorNome"];
            professor.Email = formulario["professorEmail"];
            professor.Telefone = formulario["professorTel"];
            professor.Endereco = formulario["professorEnd"];
            professor.Cargo = formulario["professorCargo"];

            professor.AtualizarProfessor(professor);

            return LocalRedirect("/");
        }
        [Route("~/Professor/{id}")]
        public IActionResult Remover(int id)
        {
            ProfessorModel.RemoverProfessor(id);

            return LocalRedirect("/Professor");
        }

        [Route("~/Professor/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = ProfessorModel.BuscarProfessor(id);
            var professorRetornado = listaRetornada.Find(professor => professor.Id == id);
            ViewBag.professorRetornado = professorRetornado;

            return View();

            return LocalRedirect("/Professor");

        }
    }
}
