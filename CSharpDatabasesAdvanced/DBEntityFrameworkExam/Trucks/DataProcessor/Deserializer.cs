namespace Trucks.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Despatchers");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportDespatcherWithTrucksDto[]), xmlRoot);

            using StringReader reader = new StringReader(xmlString);

            ImportDespatcherWithTrucksDto[] despatchers = (ImportDespatcherWithTrucksDto[])xmlSerializer.Deserialize(reader);
 
            ICollection<Despatcher> validDespatchers = new List<Despatcher>();

            foreach (var dDto in despatchers)
            {
                if (!IsValid(dDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (String.IsNullOrEmpty(dDto.Position))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Despatcher despatcher = new Despatcher
                {
                    Name = dDto.Name,
                    Position = dDto.Position
                };

                foreach (var tDto in dDto.Trucks)
                {
                    if (!IsValid(tDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (String.IsNullOrEmpty(tDto.VinNumber))
                    {

                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    bool isCorrectCategoryType = Enum.TryParse<CategoryType>(tDto.CategoryType, out CategoryType truckCategoryType);

                    if (!isCorrectCategoryType)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    bool isCorrectMakeType = Enum.TryParse<MakeType>(tDto.MakeType, out MakeType truckMakeType);

                    if (!isCorrectMakeType)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    despatcher.Trucks.Add(new Truck()
                    {
                        RegistrationNumber = tDto.RegistrationNumber,
                        VinNumber = tDto.VinNumber,
                        TankCapacity = tDto.TankCapacity,
                        CargoCapacity = tDto.CargoCapacity,
                        CategoryType = truckCategoryType,
                        MakeType = truckMakeType
                    });

                }

                validDespatchers.Add(despatcher);
                sb.AppendLine(String.Format(SuccessfullyImportedDespatcher, despatcher.Name, despatcher.Trucks.Count));               

            }

            context.Despatchers.AddRange(validDespatchers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();


        }

        public static string ImportClient(TrucksContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportClientWithTrucksDto[] clientDtos =
                 JsonConvert.DeserializeObject<ImportClientWithTrucksDto[]>(jsonString);

            ICollection<Client> validClients = new List<Client>();

            foreach (var cDto in clientDtos)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (cDto.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Client client = new Client()
                {
                    Name = cDto.Name,
                    Nationality = cDto.Nationality,
                    Type = cDto.Type
                };

                foreach (var tId in cDto.Trucks.Distinct())
                {
                    var truck = context.Trucks.FirstOrDefault(t => t.Id == tId);

                    if (truck == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    ClientTruck ct = new ClientTruck()
                    {
                        Client = client,
                        Truck = truck
                    };

                    client.ClientsTrucks.Add(ct);
                }

                validClients.Add(client);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, client.Name, client.ClientsTrucks.Count));
            }

            context.Clients.AddRange(validClients);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
