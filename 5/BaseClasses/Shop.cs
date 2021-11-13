using System.Collections.Generic;

namespace Task1.BaseClasses
{
    public class Shop
    {
        public List<Phone> Phones { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PhonesCount()
        {
            int count = 0;
            foreach (var phone in Phones)
            {
                if (phone.IsAvailable)
                {
                    count++;
                }
            }

            return count;
        }

        public int AndroidPhonesCount()
        {
            int count = 0;
            foreach (var android in Phones)
            {
                if (android.OperationSystemType == "Android" & android.IsAvailable)
                {
                    count++;
                }
            }

            return count;
        }

        public int IosPhonesCount()
        {
            int count = 0;
            foreach (var ios in Phones)
            {
                if (ios.OperationSystemType == "IOS" & ios.IsAvailable)
                {
                    count++;
                }
            }

            return count;
        }
    }
}