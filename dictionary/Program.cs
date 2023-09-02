using System.Collections.Generic;

namespace dictionary;

class Program
{
    static void Main(string[] args)
    {
        // it consists of key-value pairs
        // for easier understanding, the indexes of an array can be thought of as 
        // the keys of the dictionary, and array elements as the values of the dictionary.
        // The keys must be unique.
        // Dictionaries are located under system.collection.generic namespace.

    Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

    kullanıcılar.Add(10, "Ayşe Yılmaz");
    kullanıcılar.Add(12, "Ahmet Yılmaz");
    kullanıcılar.Add(18, "Deniz Arda");
    kullanıcılar.Add(20, "Özcan Coşar");

    //Accessing the elements of the dictionary
    Console.WriteLine("***accessing elements***");
    Console.WriteLine(kullanıcılar[12]);
    foreach (var item in kullanıcılar)
           Console.WriteLine(item);

    //Count;
    Console.WriteLine("**Count**");
    Console.WriteLine(kullanıcılar.Count);

    //Contains function;
    Console.WriteLine("**Contains**");
    Console.WriteLine(kullanıcılar.ContainsKey(12));
    Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

    //when the key-value pair is not unique;
    //kullanıcılar.Add(10, "Ayşe Yılmaz");

    //Remove;
    Console.WriteLine("**Remove**");
    kullanıcılar.Remove(12);
        foreach (var item in kullanıcılar)
           Console.WriteLine(item);
    
    //Keys
    Console.WriteLine("**Keys**");
    foreach (var item in kullanıcılar.Keys)
        Console.WriteLine(item);
        
    //Values
    Console.WriteLine("**Values**");
    foreach (var item in kullanıcılar.Values)
        Console.WriteLine(item);
    }
}
