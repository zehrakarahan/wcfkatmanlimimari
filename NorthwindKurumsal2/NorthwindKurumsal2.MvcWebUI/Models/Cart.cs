using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindKurumsal2.MvcWebUI.Models
{
    public class Cart
    {
        List<CartUrunler> _lines = new List<CartUrunler>();



        public void AddToCart(Product product, int quantity)
        {
            CartUrunler cartLine = _lines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);

            if (cartLine == null)
            {
                _lines.Add(new CartUrunler { Product = product, Quantity = quantity });
            }
            else
            {
                cartLine.Quantity = cartLine.Quantity + quantity;
            }
        }
        public void RemoveFromCart(Product product)
        {
            _lines.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }
        public decimal Total()
        {
            return _lines.Sum(c => c.Product.Price * c.Quantity);
        }
        public void Clear()
        {
            _lines.Clear();
        }
        public List<CartUrunler> Lines()
        {

            return _lines;
        }
    }
}