using System.Collections.Generic;
using System.Linq;

namespace P2FixAnAppDotNetCode.Models
{
    /// <summary>
    /// The Cart class
    /// </summary>
    public class Cart : ICart
    {

        private readonly List<CartLine> _cartLines = new List<CartLine>();

        /// <summary>
        /// Read-only property for display only
        /// </summary>
        public IEnumerable<CartLine> Lines => _cartLines.AsReadOnly();

        /// <summary>
        /// Return the actual cartline list
        /// </summary>
        /// <returns></returns>
        private List<CartLine> GetCartLineList()
        {
            return new List<CartLine>();
        }

        /// <summary>
        /// Adds a product in the cart or increment its quantity in the cart if already added
        /// </summary>//
        public void AddItem(Product product, int quantity)
        {
            var cartLine = _cartLines.FirstOrDefault(cl => cl.Product.Id == product.Id);
            if (cartLine != null)
            {
                cartLine.Quantity += quantity;
            }
            else
            {
                _cartLines.Add(new CartLine { Product = product, Quantity = quantity });
            }
        }

        /// <summary>
        /// Removes a product form the cart
        /// </summary>
        public void RemoveLine(Product product) 
        {
            var cartLineToRemove = _cartLines.FirstOrDefault(cl => cl.Product.Id == product.Id);

            if (cartLineToRemove != null)
            {
                _cartLines.Remove(cartLineToRemove);
            }
        }

        /// <summary>
        /// Get total value of a cart
        /// </summary>
        public double GetTotalValue()
        {
            if (_cartLines.Count == 0)
            {
                return 0.0;
            }

            double totalValue = 0.0;

            foreach (var cartLine in _cartLines)
            {
                totalValue += cartLine.Product.Price * cartLine.Quantity;
            }
            return totalValue;
        }

        /// <summary>
        /// Get average value of a cart
        /// </summary>
        public double GetAverageValue()
        {
            if (_cartLines.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double totalValue = GetTotalValue();

                int totalQuantity = _cartLines.Sum(cl => cl.Quantity);

                return totalValue / totalQuantity;
            }
        }

        /// <summary>
        /// Looks after a given product in the cart and returns if it finds it
        /// </summary>
        public Product FindProductInCartLines(int productId)
        {
            var cartLineToFind = _cartLines.Find(cl => cl.Product.Id == productId);

            if (cartLineToFind != null)
            {
                return cartLineToFind.Product;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get a specific cartline by its index
        /// </summary>
        public CartLine GetCartLineByIndex(int index)
        {
            return Lines.ToArray()[index];
        }

        /// <summary>
        /// Clears a the cart of all added products
        /// </summary>
        public void Clear()
        {
            _cartLines.Clear();
        }
    }

    public class CartLine
    {
        public int OrderLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
