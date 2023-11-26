using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uc4.Models;
using static uc4.Models.UsuarioRepository;

namespace uc4.Controllers

{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if (usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                HttpContext.Session.SetInt32("idUsuario", usuario.Id);
                HttpContext.Session.SetString("nomeUsuario", usuario.Nome);
                return Redirect("Logado");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }

        public IActionResult Logado()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
            return View();
        }
         public IActionResult Pedidos()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
            return View();
        }

        [HttpPost]
        public IActionResult Pedidos(Pedidos u)
        {
            PedidosRepository ur = new PedidosRepository ();
            ur.Insert(u);
            ViewBag.Mensagem = "Pedido Cadastrado com sucesso";
            return View();
        }
        public IActionResult Listagem()
{
        if(HttpContext.Session.GetInt32("idUsuario") == null)
        return RedirectToAction("Login");
        PedidosRepository ur = new PedidosRepository();
        List<Pedidos> pedidos = ur.Query();
        return View(pedidos);
}

    public IActionResult Editar(int Id)
        {
            PedidosRepository pR = new PedidosRepository();
            return View(pR.BuscarPorId(Id));
        }

        [HttpPost]
          public IActionResult Editar(Pedidos p)
        {
            PedidosRepository pR = new PedidosRepository();
            pR.Editar(p);
            return RedirectToAction("Listagem");
        }

        public IActionResult Deletar(int Id)
        {
            PedidosRepository pR = new PedidosRepository();
            pR.Deletar(Id);
            return RedirectToAction("Listagem");
        }

    }
}