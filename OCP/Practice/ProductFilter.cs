using OCP.Practice.Enums;

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

    // Voilation of Open Closed Principles, Classes open for extension and closed for modification such FilterBySizeAndColor Modification
    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        foreach (var product in products)
        {
            if(product.Size == size && product.Color == color)
            {
                yield return product;
            }
        }
    }
}
