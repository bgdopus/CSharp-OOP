namespace HomeworkDefiningClassesPart1
{
    using System;
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, LiPro
    }
    public class Battery
    {
        private string model;
        private ushort? hoursIdle;
        private ushort? hoursTalk;
        private BatteryType? batteryType;

        public Battery()
            : this(null, null, null, null)
        {
        }

        public Battery(string model)
                : this(model, null, null, null)
        {
        }

        public Battery(ushort? hoursIdle)
                : this(null, hoursIdle, null, null)
        {
        }
        public Battery(ushort? hoursIdle, ushort? hoursTalk)
                : this(null, hoursIdle, hoursTalk, null)
        {
        }


        public Battery(string model, ushort? hoursIdle, ushort? hoursTalk, BatteryType? batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                // Battery model length can't be less than 3 chars, otherwise an exeption is thrown
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("Battery model can't be less than 3 symbols!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

       
        public ushort? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        
        public ushort? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

       
        public BatteryType? BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        public override string ToString()
        {
            return string.Format("Model: {0}\nIdle hours: {1}, Talk hours: {2}\nBattery type: {3}",
                this.Model ?? "unknown", this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }
   
}