﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FerragensOnline.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FerragensOnline.Controllers
{
    public class PublicoController : Controller
    {
        private readonly Context _context;

        public PublicoController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar()
        {
            return View();
        }

        public IActionResult AcessoNegado()
        {
            return View();
        }

        public IActionResult Logout()
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Append("Email", "", cookie);

            return RedirectToAction("Logar", "Publico");
        }

        [HttpPost]
        public IActionResult Logar(string email, string senha)
        {
            string user = AutenticarUser(email, senha);
            if (user == "")
            {
                ViewBag.Error = "E-mail e/ou senha incorreto(s)";
                return View();
            }
            else
            {
                CookieOptions cookie = new CookieOptions();
                cookie.Expires = DateTime.Now.AddMinutes(5);
                Response.Cookies.Append("Email", user, cookie);
                return RedirectToAction("Index", "Home");


            }
        }

        public string AutenticarUser (string email, string senha)
        {
            var query = (from u in _context.Vendedores
                         where u.Email == email &&
                         u.Senha == senha
                         select u).SingleOrDefault();
            if(query == null)
            {
                return "";
            }
            else
            {
                return query.Email;
            }
        }
    }
}
