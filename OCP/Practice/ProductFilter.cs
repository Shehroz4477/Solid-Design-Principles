using System.Collections.Generic;
using System.Drawing;

namespace OCP.Practice;

public class ProductFilter
{
    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (Product product in products)
        {
            if(product.Size == size)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (Product product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }
}
