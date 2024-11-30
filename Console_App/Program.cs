namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saati Giriniz (0-23): ");
            int alarmSaat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dakikayı Giriniz (0-59): ");
            int alarmDakika = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alarm kuruldu! Şu anki saat ve alarm saati ekranda görüntülenecek...");
            Thread.Sleep(1000);

            do
            {
                Console.Clear();
                Console.WriteLine($"Şu Anki Saat: {DateTime.Now}");
                Console.WriteLine($"Alarm Saati: {alarmSaat}:{alarmDakika}");

                if (DateTime.Now.Hour == alarmSaat && DateTime.Now.Minute == alarmDakika)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("ALARM! ALARM! ALARM!");
                        Console.Beep();
                        Thread.Sleep(500);
                    }
                    break;
                }

                Thread.Sleep(1000);
            } while (true);

            Console.WriteLine("Program sona erdi.");
        }
    }
}
