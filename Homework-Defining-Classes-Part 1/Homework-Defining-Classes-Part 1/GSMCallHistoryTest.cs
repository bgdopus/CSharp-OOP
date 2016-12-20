namespace HomeworkDefiningClassesPart1
{
    using System;
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM acer = new GSM("X1", "Acer", 1200, "Ace Master",
                new Battery("Non-removable Li-Po 1560 mAh battery (5.92 Wh)", 250, 10, BatteryType.LiPro),
                new Display(16, 1136, 640));

            Call first = new Call(acer, DateTime.Now, "0876050549", 123);
            acer.AddCall(first);

            Call second = new Call(acer, DateTime.Now, "0876050548", 200);
            acer.AddCall(second);

            Call third = new Call(acer, DateTime.Now, "0876980549", 250);
            acer.AddCall(third);

            acer.PrintCallHistory();
        }
    }
}
