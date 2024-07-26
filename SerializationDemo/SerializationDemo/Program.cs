// See https://aka.ms/new-console-template for more information

using SerializationDemo;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\\Keshav\Sample.pdf";
        Employee emp = new Employee(123,"Keshav");
        FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(stream, emp);
        stream.Close();
        Console.WriteLine("File Created Successfully - > " + path);



    }
}