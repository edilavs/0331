using System;
using ClassLibrary;

namespace HW0331
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masinlarin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            Car[] cars = new Car[count];
            
            

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();

                Console.WriteLine($"{i + 1}.ci Masinin brandini daxil edin:");
                cars[i].Brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}.ci Masinin rengini daxil edin:");
                cars[i].Color  = Console.ReadLine();
                Console.WriteLine($"{i + 1}.ci Masinin millage-ni daxil edin:");
                cars[i].Millage  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci Masinin benzin tutumunu daxil edin:");
                cars[i].FuelCapacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci Masinin  hazirki benzin miqdarini  daxil edin:");
                cars[i].CurrentFuel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{i + 1}.ci Masinin 1km ucun lazim olan benzin miqdarini daxil edin:");
                cars[i].FuelFor1km = Convert.ToDouble(Console.ReadLine());
            }

            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Masınları millage - e gore filtirle\n2.Butun masınları goster\n3.Prosesi bitir");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Millage ucun min deyer:");
                        int minMillage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Millage ucun max deyer:");
                        int maxMillage = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cars.Length; i++)
                        {
                            int counter=0;
                            if (cars[i].Millage >= minMillage && cars[i].Millage <= maxMillage)
                                counter++;
                            if (counter > 0)
                                Console.WriteLine($"Deyerlere uygun masin:{cars[i].Brand},{cars[i].Millage}\n");
                        }
                        break;

                    case "2":
                        foreach (var item in cars)
                            Console.WriteLine($"{item.Brand},{item.Color},{item.Millage },{item.FuelCapacity},{item.CurrentFuel },{item.FuelFor1km}\n");
                        break;

                    case "3":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("    1,2 ve 3 secimi etmelisiz!  ");
                        break;
                }
            }
        }
    }
}
