using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace BL
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        [Required]
        public decimal RetailPrice { get; set; }

        public decimal WholesalePrice { get; set; }
        public Guid? ImageId { get; set; }
        public Guid? Asset { get; set; }

        public ProductViewModel()
        {
        }

        public bool IsEmpty
        {
            get => Name == null;
        }

        public ProductViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            ImageId = product.AssetId;
            RetailPrice = product.RetailPrice;
            WholesalePrice = product.WholesalePrice;
            CategoryName = product.Category?.Name;
        }

        public static implicit operator Product(ProductViewModel model)
        {
            return new Product
            {
                Id = model.Id,
                Description = model.Description,
                RetailPrice = model.RetailPrice,
                WholesalePrice = model.WholesalePrice,
                AssetId = model.ImageId,
                CategoryId = model.CategoryId,
                Name = model.Name
            };
        }

        public static ProductViewModel GetProductById(Guid id, IProductRepository repository)
        {
            return (repository.AllItems as DbSet<Product>)
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .Select(p => new ProductViewModel(p))
                .First();
        }

        public static IQueryable<ProductViewModel> GetProductList(IProductRepository repository, Guid? categoryId = null)
        {
            if (categoryId.HasValue)
            {
                return (repository.AllItems as DbSet<Product>)
                    .Where(p => p.CategoryId == categoryId)
                    .Select(p => new ProductViewModel(p));
            }
            return (repository.AllItems as DbSet<Product>)
                .Include(p => p.Category)
                .Select(p => new ProductViewModel(p));
        }
    }
}