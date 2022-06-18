// See https://aka.ms/new-console-template for more information
using UPBhulekh.LookForName;

Console.WriteLine("Starting now .. ");

string name = "अशोक";
List<string> vccs = new List<string> { "191191" };
UsingVCC_Gram khataDetails = new UsingVCC_Gram();
khataDetails.Fetch(name, vccs);

string csvFile = @"C:\Users\Nikhil\Downloads\KhataDetails.csv";
khataDetails.Publish(csvFile);

Console.WriteLine("Completed !!");
