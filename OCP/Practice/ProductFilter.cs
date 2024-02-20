using System.Drawing;

namespace OCP.Practice;

public class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (Product product in products)
        {
            if(product.Size == size)
            {
                yield return product;
            }
        }
    }
}
