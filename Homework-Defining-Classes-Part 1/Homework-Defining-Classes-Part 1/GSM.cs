using System;
using System.Collections.Generic;


namespace HomeworkDefiningClassesPart1
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        private static GSM IPhone4S;

        private List<Call> callHistory = new List<Call>();
        public GSM(string model, string manufacturer):this(model, manufacturer, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price) : this(model, manufacturer, price, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner) : this(model, manufacturer, price, owner, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery) : this(model, manufacturer, price, owner, battery, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
             
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                // Minimum length of the string is 3 chars, otherwise an exeption is thrown
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("GSM model can't be less than 3 symbols!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                // Minimum length of the string is 3 chars, otherwise an exeption is thrown
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("GSM manufacturer can't be less than 3 symbols!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public decimal? Price
        {
            get { return this.price; }
            set
            {
                // The price can't be negative
                if (value != null && value < 0)
                {
                    throw new ArgumentException("GSM price can't be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("GSM owner name can't be less than 3 symbols!!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}", this.model, this.manufacturer);
        }

        static GSM()
        {
            IPhone4S = new GSM("iPhone4s", "Apple", 450, "Nikolai",
           new Battery("Non-removable Li-Po 1432 mAh battery (5.3 Wh)", 200, 14, BatteryType.LiPro),
           new Display(16, 960, 640));
        }
        public static GSM IPhone4s
        {
            get { return IPhone4S; }
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }
        public void DeleteCallHistory(int index)
        {
            this.CallHistory.Remove(this.callHistory[index]);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            private set
            {
                this.callHistory = value;
            }
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0.37M;
            ulong totalDurationInSeconds = 0;
            ulong totalDurationInMinutes = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalDurationInSeconds += callHistory[i].Duration;
            }
            totalDurationInMinutes = (totalDurationInSeconds / 60);
            if (totalDurationInSeconds % 60 != 0)
            {
                totalDurationInMinutes++;
            }

            totalPrice = totalDurationInMinutes * totalPrice;
            return totalPrice;
        }

        public void PrintCallHistory()
        {
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
        }

        public void DeleteLastCall()
        {
            if (callHistory.Count == 0)
            {
                throw new ArgumentNullException("Trying to delete element in empty array!");
            }
            else
            {
                callHistory.RemoveAt(callHistory.Count - 1);
            }
        }

      
        public void DeleteLongestCall()
        {
            uint longestDuration = 0;
            int longestDurationIndex = 0;

            
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration > longestDuration)
                {
                    longestDuration = callHistory[i].Duration;
                    longestDurationIndex = i;
                }
            }

            callHistory.RemoveAt(longestDurationIndex);
        }

        
       
    }

}
