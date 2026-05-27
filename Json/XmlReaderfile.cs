using System;
using System.Xml;

class XMLReaderExample
{
    public static void ReadXML()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("/Users/bishnugiri/Desktop/OOP/Json/users.xml");

        XmlNodeList? users = doc.SelectNodes("//user");

        if (users != null)
        {
            foreach (XmlNode user in users)
            {
                Console.WriteLine("Name: " + user["name"]?.InnerText);
                Console.WriteLine("Age: " + user["age"]?.InnerText);
                Console.WriteLine("City: " + user["city"]?.InnerText);
                Console.WriteLine();
            }
        }
    }
}