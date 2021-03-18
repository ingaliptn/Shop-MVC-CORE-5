using BL;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List(Guid? id)
        {
            return View(ProductViewModel.GetProductList(_productRepository, id));
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

        public IActionResult Edit(Guid id)
        {
            return View(ProductViewModel.GetProductById(id, _productRepository));
        }

        public async Task<IActionResult> AcceptEdit(ProductViewModel model)
        {
            if (model != null && !model.IsEmpty)
            {
                await ProductViewModel.Edit(model, _productRepository);
            }
            return Redirect("~/Product/List");
        }

        public IActionResult Delete(Guid id)
        {
            return View(ProductViewModel.GetProductById(id, _productRepository));
        }

        public async Task<IActionResult> AcceptDelete(Guid? id)
        {
            if (id.HasValue)
            {
                await _productRepository.DeleteItemAsync(id.Value);
            }
            return Redirect("~/Product/List");
        }

        public IActionResult Details(Guid id)
        {
            return View(ProductViewModel.GetProductById(id, _productRepository));
        }
    }
}