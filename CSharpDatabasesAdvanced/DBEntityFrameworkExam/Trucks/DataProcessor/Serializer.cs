namespace Trucks.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ExportDto;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportDespatchersWithTheirTrucks(TrucksContext context)
        {
            StringBuilder sb = new StringBuilder();

            using StringWriter writer = new StringWriter(sb);

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Despatchers");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportDespatcherWithTrucks[]), xmlRoot);

            var despatchers = context.Despatchers
                .Where(d => d.Trucks.Count >= 1)
                .ToArray()
                .Select(d => new ExportDespatcherWithTrucks()
                {
                    TrucksCount = d.Trucks.Count,
                    DespatcherName = d.Name,
                    Trucks = d.Trucks
                    .Select(t => new ExportDespatcherTruck()
                    {
                        RegistrationNumber = t.RegistrationNumber,
                        Make =  t.MakeType.ToString()
                        //Make = Enum.GetName(typeof(MakeType), t.MakeType)
                    })
                    .OrderBy(t => t.RegistrationNumber)
                    .ToArray()
                })
                .OrderByDescending(d => d.TrucksCount)
                .ThenBy(d => d.DespatcherName)

                .ToArray();

            xmlSerializer.Serialize(writer, despatchers, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ExportClientsWithMostTrucks(TrucksContext context, int capacity)
        {
            var clients = context.Clients
                .Where(c => c.ClientsTrucks.Any(t => t.Truck.TankCapacity >= capacity))
                .ToArray()
                .Select(c => new
                {
                    Name = c.Name,
                    Trucks = c.ClientsTrucks
                    .Where(t => t.Truck.TankCapacity >= capacity)
                    .ToArray()
                    .Select(t => new
                    {
                        TruckRegistrationNumber = t.Truck.RegistrationNumber,
                        VinNumber = t.Truck.VinNumber,
                        TankCapacity = t.Truck.TankCapacity,
                        CargoCapacity = t.Truck.CargoCapacity,
                        CategoryType = Enum.GetName(typeof(CategoryType), t.Truck.CategoryType),
                        MakeType = Enum.GetName(typeof(MakeType), t.Truck.MakeType) 
                    })
                    .OrderBy(t => t.MakeType)
                    .ThenByDescending(t => t.CargoCapacity)
                    .ToArray()
                })
                .OrderByDescending(c => c.Trucks.Count())
                .ThenBy(c => c.Name)
                .Take(10)
                .ToArray();

            string json = JsonConvert.SerializeObject(clients, Formatting.Indented);

            return json;

        }
    }
}
