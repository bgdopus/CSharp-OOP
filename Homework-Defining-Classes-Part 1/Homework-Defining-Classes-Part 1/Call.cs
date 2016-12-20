namespace HomeworkDefiningClassesPart1
{
    using System;
    public class Call
    {
        private GSM phone;
        private DateTime date;
        private string dialedNumber;
        private uint duration;

        public Call(GSM phone, DateTime date, string dialedNumber, uint duration)
        {
            this.Phone = phone;
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public GSM Phone
        {
            get { return this.phone; }
            set { this.phone = value;  }
        }
        public DateTime Date
        {
            get { return this.date; }
            set {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Can't add future date!");
                }
                else
                {
                    this.date = value;
                }
            }
        }
        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set
            {
                if (value.Length < 7)
                {
                    throw new ArgumentException("Can't phone number less than 7 digits!");
                }
                else
                {
                    this.dialedNumber = value;
                }
            }
        }
        public uint Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The duration cannot be less than 1 second!");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Date: {0}, Number: {1}, Duration: {2} Seconds", date, dialedNumber, duration);
        }

    }
}
