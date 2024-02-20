using OCP.Practice;
using OCP.Practice.Enums;
using SRP.Practice;

#region SRP Demo Output
//var journal = new Journal();
//journal.AddEntry("Somting 1");
//journal.AddEntry("Somting 2");
//journal.AddEntry("Somting 3");
//Console.WriteLine(journal.ToString());


//var persistence = new Persistence();
//var fileName = @"c:\CSharpOutputFile\journal.txt";
//persistence.SaveToFile(journal, fileName,true);
//Process.Start(fileName);
#endregion

#region OCP Demo Output
var laptop = new Product("HP Laptop", Color.Red, Size.Meduim);
var lcd = new Product("LCD Screen", Color.Blue, Size.Large);
var headPhone = new Product("Head Phone", Color.Blue, Size.Small);

Product[] products = {laptop, lcd, headPhone};

var productFilter = new ProductFilter();
foreach (var product in productFilter.FilterByColor(products, Color.Blue))
{
    Console.WriteLine($"- {product.Name} is {product.Color}");
}
#endregion
