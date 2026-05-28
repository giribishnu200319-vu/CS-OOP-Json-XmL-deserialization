using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class Admin: User
    {
        public required string Role { get; set; }
    }

    static void Main(string[] args)
    {
        // string filePath = "/Users/bishnugiri/Desktop/OOP/Json/users.json";

        // Read JSON file
        // string jsonData = File.ReadAllText(filePath);
        // XMLReaderExample.ReadXML();

        string adminJson =
            File.ReadAllText("/Users/bishnugiri/Desktop/OOP/Json/admins.json");

        List<Admin> admins =
            JsonConvert.DeserializeObject<List<Admin>>(adminJson)
            ?? new List<Admin>();

        foreach (Admin user in admins)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + user.Age);
            Console.WriteLine("City: " + user.City);
            Console.WriteLine("Role: " + user.Role);
        }
        // Deserialize JSON array into List<User>
        // List<User> users =
        //     JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();

        // // Add new entries
        // users.Add(new User
        // {
        //     Name = "Michael",
        //     Age = 28,
        //     City = "Berlin"
        // });
        // users.Add(new User
        // {
        //     Name = "Sarah",
        //     Age = 24,
        //     City = "Madrid"
        // });

        // // Convert back to JSON
        // string updatedJson =
        //     JsonConvert.SerializeObject(users, Formatting.Indented);

        // // Save updated JSON
        // File.WriteAllText(filePath, updatedJson);

        // // LOOP through all users
        // Console.WriteLine("All Users:");

        // foreach (User user in users)
        // {
        //     Console.WriteLine("----------------");
        //     Console.WriteLine("Name: " + user.Name);
        //     Console.WriteLine("Age: " + user.Age);
        //     Console.WriteLine("City: " + user.City);
        // }
    
    }
}