using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class CadastroFestaController : Controller
    {
        public IActionResult Index(string FestaID ,string Nome, string Cidade, string Endereco, string Estado,string DataFesta, string Bairro, string PrecoIngresso)
        {
            var objeto = new CadastroFesta();
            objeto.FestaID = FestaID;
            objeto.Nome = Nome;
           return View(objeto);}

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(CadastroFesta Nome)
        {
            var db = new Contexto();

            var obj = db.CadastroFesta.FirstOrDefault(f => f.FestaID == CadastroFesta.FestaID);

            if (obj == null)
            {
                db.FestaID.Add(FestaID);
            }
            else
            {
                obj.Nome = FestaID.Nome;
                db.FestaID.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(string FestaID)
        {
            var db = new Contexto();
            var FestaID = db.FestaID.First(item => item. == FestaID);
            return View("Adicionar", FestaID);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeFestas = new Contexto().CadastroFesta.ToList();

            return View(listaDeFestas);
        }

        public IActionResult Excluir(string FestaID)
        {
            var db = new Contexto();
            var Festa = db.CadastroFesta.First(f => f.FestaID == FestaID);
            db.FestaID.Remove(FestaID);
            db.SaveChanges();

            return RedirectToAction("Listar");


        }
}
