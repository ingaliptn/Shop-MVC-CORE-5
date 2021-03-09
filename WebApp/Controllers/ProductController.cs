using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Repositories;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            return View(ProductViewModel.GetProductList(_productRepository));
        }

        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (model.IsEmpty)
            {
                return View(model);
            }

            if (await _productRepository.AddItemAsync(model))
            {
                return Redirect("List");
            }

            return Redirect("Error");
        }

        public IActionResult Details(Guid id)
        {
            return View(ProductViewModel.GetProductById(id, _productRepository));
        }
    }
}