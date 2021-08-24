using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            u.Senha = Criptografo.TextoCriptografado(u.Senha);

            UsuarioService us = new UsuarioService();
            us.Inserir(u);

            return RedirectToAction("cadastroRealizado");
        }

        public IActionResult cadastroRealizado()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            return View();
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);

            return View();
        }

        public IActionResult Edicao(int id)
        {
            Usuario u = new UsuarioService().Listar(id);

            return View(u);
        }
        [HttpPost]
        public IActionResult Edicao(Usuario u)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            UsuarioService us = new UsuarioService();
            us.Atualizar(u);

            return RedirectToAction("Listagem");
        }

        public IActionResult Exclusao(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar(id));
        }
        [HttpPost]
        public IActionResult Exclusao(string decisao, int id)
        {
            if(decisao == "EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão do usuário "+new UsuarioService().Listar(id).Nome+" realizada com sucesso";
                new UsuarioService().Excluir(id);

                return View("Listagem", new UsuarioService().Listar());
            }
            else
            {
                ViewData["Mensagem"] = "Exclusão cancelada";
                
                return View("Listagem", new UsuarioService().Listar());
            }
        }

        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);

            return View(new UsuarioService().Listar());
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}