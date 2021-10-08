using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Controllers
{
    [Route("Aluno")]
    public class AlunoController : Controller
    {
        Aluno alunoModel = new Aluno();
        public IActionResult Index()
        {
            ViewBag.ListaDeAlunos = alunoModel.ListarAluno();
            return View();
        }

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection formulario)
        {

            Aluno aluno = new Aluno();

            aluno.Nome = formulario["alunoNome"];
            aluno.Email = formulario["alunoEmail"];
            aluno.Telefone = formulario["alunoTel"];
            aluno.Endereco = formulario["alunoEnd"];
            aluno.Escolaridade = formulario["alunoEsc"];

            aluno.CadastrarAluno(aluno);

            return LocalRedirect("/");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Aluno aluno = new Aluno();

            aluno.Id = int.Parse(formulario["alunoId"]);
            aluno.Nome = formulario["alunoNome"];
            aluno.Email = formulario["alunoEmail"];
            aluno.Telefone = formulario["alunoTel"];
            aluno.Endereco = formulario["alunoEnd"];
            aluno.Escolaridade = formulario["alunoEsc"];

            aluno.AtualizarAluno(aluno);

            return LocalRedirect("/");
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Route("~/Aluno/{id}")]
        public IActionResult Remover(int id)
        {
            alunoModel.RemoverAluno(id);

            return LocalRedirect("/Aluno");
        }

        [Route("~/Aluno/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = alunoModel.BuscarPorId(id);
            var alunoRetornado = listaRetornada.Find(aluno => aluno.Id == id);
            ViewBag.alunoRetornado = alunoRetornado;

            return View();

            return LocalRedirect("/Aluno");

        }
    }
}
