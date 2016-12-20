namespace HomeworkDefiningClassesPart1
{
    using System;
    class GSMTest
    {
        public void PrintPhones()
        {
            GSM apple = new GSM("iPhone5s", "Apple", 1200, "Steve Jobs",
                new Battery("Non-removable Li-Po 1560 mAh battery (5.92 Wh)", 250, 10, BatteryType.LiPro),
                new Display(16, 1136, 640));

            
            Battery nokiaBattery = new Battery("Non-removable Li-Ion 3400 mAh battery (BV-4BW)", 672, 25, BatteryType.LiIon);
            Display nokiaDisplay = new Display(16, 1280, 720);

            
            GSM nokia = new GSM("Lumia 1320", "Nokia", 1000, "Pesho", nokiaBattery, nokiaDisplay);

            
            GSM samsung = new GSM("Galaxy S4", "Samsung");

            
            samsung.Price = 1250;
            samsung.Owner = "Dr. Oh-Hyun Kwon";
            samsung.Battery = new Battery("Li-Ion 2600 mAh battery", 370, 17, BatteryType.LiIon);
            samsung.Display = new Display(16, 1920, 1080);

            
            GSM[] gsms = new GSM[] { apple, nokia, samsung };
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine(gsms[i]); // No need to explicitly call ToString()
                Console.WriteLine("Price: {0}", gsms[i].Price);
                Console.WriteLine("Owner: {0}", gsms[i].Owner);
                Console.WriteLine(gsms[i].Battery);
                Console.WriteLine("Display size: {0}", gsms[i].Display.Size);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4s); 
            Console.WriteLine("Price: {0}", GSM.IPhone4s.Price);
            Console.WriteLine("Owner: {0}", GSM.IPhone4s.Owner);
            Console.WriteLine(GSM.IPhone4s.Battery);
            Console.WriteLine("Display size: {0}", GSM.IPhone4s.Display.Size);
        }
    }
}
