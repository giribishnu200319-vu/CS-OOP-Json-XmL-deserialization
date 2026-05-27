using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Base class
    public class User
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string City { get; set; }
    }

    static void Main(string[] args)
    {
        string filePath = "/Users/bishnugiri/Desktop/OOP/Json/users.json";

        // Read JSON file
        string jsonData = File.ReadAllText(filePath);
        XMLReaderExample.ReadXML();

        // Deserialize JSON array into List<User>
        List<User> users =
            JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();

        // Add new entry
        users.Add(new User
        {
            Name = "Michael",
            Age = 28,
            City = "Berlin"
        });

        // Convert back to JSON
        string updatedJson =
            JsonConvert.SerializeObject(users, Formatting.Indented);

        // Save updated JSON
        File.WriteAllText(filePath, updatedJson);

        // LOOP through all users
        Console.WriteLine("All Users:");

        foreach (User user in users)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + user.Age);
            Console.WriteLine("City: " + user.City);
        }
    }
}