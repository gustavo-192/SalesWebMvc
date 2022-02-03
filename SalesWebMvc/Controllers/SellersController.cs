﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //Declarando dependência para o SellerService
        private readonly SellerService _sellerService;
        //Declarando dependência para o DepartamentService
        private readonly DepartamentService _departamentService;

        //Injeção de dependência
        public SellersController(SellerService sellerService, DepartamentService departamentService)
        {
            _sellerService = sellerService;
            _departamentService = departamentService;
        }

        public IActionResult Index()
        {
            //Retorna uma lista de Seller
            var list = _sellerService.FindAll();
            //Passando a lista para o método View
            return View(list);
        }

        //Método que abre o formulário para cadastrar o vendedor
        public IActionResult Create()
        {
            //Carregando departamentos do banco
            var departaments = _departamentService.FindAll();
            var viewModel = new SellerFormViewModel { Departaments = departaments};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
