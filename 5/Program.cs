using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Task1.BaseClasses;
using JsonException = Newtonsoft.Json.JsonException;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger<Program> logger = new MyLogger<Program>().Logger;

            var fileName = "info.json";
            try
            {
                var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var path = $"{basePath}{Path.DirectorySeparatorChar}{fileName}";


                string json = Convert.ToString(File.ReadAllText(path));
                Root rootClass = JsonConvert.DeserializeObject<Root>(json);

                rootClass.DisplayInfo();
                rootClass.PhoneSearch("Which mobile phone do you want to buy?");
            }

            catch (FileLoadException e)
            {
                logger.LogError(e.Message);
                throw;
            }

            catch (JsonException e)
            {
                logger.LogError(e.Message);
                throw;
            } 
            catch (NullReferenceException e)
            {
                logger.LogError(e.Message);
                throw;
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}