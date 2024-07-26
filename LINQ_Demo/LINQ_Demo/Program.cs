// See https://aka.ms/new-console-template for more information
int[] age = { 12, 23, 21, 22, 456, 10, 11, 45 };
var a = from i in age where i > 20 orderby  i select i;

string[] names = { "Keshav", "Madhav", "Pranav", "Suraj", "Praney" };
//var a1 = from name in names where name.Contains("a") select name;
var a1 = from name in names where name.StartsWith("S") select name;

foreach (string item in a1)
{
    Console.WriteLine(item);
}
