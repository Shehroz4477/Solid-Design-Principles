using SRP.Practice;
//using System.Diagnostics;

var journal = new Journal();
journal.AddEntry("Somting 1");
journal.AddEntry("Somting 2");
journal.AddEntry("Somting 3");
Console.WriteLine(journal.ToString());


var persistence = new Persistence();
var fileName = @"c:\CSharpOutputFile\journal.txt";
persistence.SaveToFile(journal, fileName,true);
//Process.Start(fileName);
