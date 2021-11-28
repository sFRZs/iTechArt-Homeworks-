using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Task1.Exceptions;

namespace Task1.BaseClasses
{
    public class Root
    {
        public List<Shop> Shops { get; set; }
        private ILogger<Root> logger = new MyLogger<Root>().Logger;

        public void DisplayInfo()
        {
            foreach (var shop in Shops)
            {
                logger.LogInformation(
                    $"{shop.Id} | {shop.Name}\n\tDescription: {shop.Description}\n\tPhones available: {shop.PhonesCount()} (Android: {shop.AndroidPhonesCount()}, IOS: {shop.IosPhonesCount()})");
            }
        }

        public void PhoneSearch(string message)
        {
            logger.LogInformation(message + "\n-> ");
            string phoneModel = Console.ReadLine();

            int count = 0;
            var shopsWithPhone = new Dictionary<Phone, Shop>();

            for (int i = 0; i < Shops.Count; i++)
            {
                for (int j = 0; j < Shops[i].Phones.Count; j++)
                {
                    if (Shops[i].Phones[j].Model == phoneModel)
                    {
                        count++;
                        if (Shops[i].Phones[j].IsAvailable)
                        {
                            shopsWithPhone.Add(Shops[i].Phones[j], Shops[i]);
                            break;
                        }
                    }
                }
            }

            try
            {
                if (shopsWithPhone.Count != 0)
                {
                    logger.LogInformation("ShopId" + "|" + "\t Phone Model    " + " | " + "   OS  " + " |" +
                                          "   MarketLaunchDate " + " | " + "Price" + " | " + "Shop");
                    foreach (var item in shopsWithPhone)
                    {
                        logger.LogInformation(
                            $"{item.Key.ShopId,5} | {item.Key.Model,18} | {item.Key.OperationSystemType,7} | \t {item.Key.MarketLaunchDate,11} \t | ${item.Key.Price,4} | {item.Value.Name}");
                    }

                    ShopSearch($"\nIn which store do you want to buy the mobile phone {phoneModel}?", shopsWithPhone);
                }

                else if (count == 0)
                {
                    throw new PhoneNotFoundException("This mobile phone is not found.");
                }
                else if (count > shopsWithPhone.Count)
                {
                    throw new PhoneNotAvailableException("This mobile phone is out of stock.");
                }
            }

            catch (PhoneNotFoundException e)
            {
                logger.LogError(e.Message);

                PhoneSearch("Please, enter a another phone model: ");
            }

            catch (PhoneNotAvailableException e)
            {
                logger.LogError(e.Message);
                PhoneSearch("Please, enter a another phone model: ");
            }
        }

        private void ShopSearch(string message, Dictionary<Phone, Shop> shops)
        {
            logger.LogInformation(message + "\n-> ");
            string shopName = Console.ReadLine();

            Phone phone = null;
            Shop shop = null;

            foreach (var item in shops)
            {
                if (item.Value.Name == shopName)
                {
                    phone = item.Key;
                    shop = item.Value;
                    break;
                }
            }

            try
            {
                if (shop != null & phone != null)
                {
                    logger.LogInformation(
                        $"Order for {phone.Model} ({phone.OperationSystemType}), price ${phone.Price}, market launch date {phone.MarketLaunchDate}, in shop \"{shop.Name}\" has been successfully placed.");
                }
                else
                {
                    throw new ShopNotFoundException("This shop is not found.");
                }
            }

            catch (ShopNotFoundException e)
            {
                logger.LogError(e.Message);
                ShopSearch("Please, enter a another shop: ", shops);
            }
        }
    }
}