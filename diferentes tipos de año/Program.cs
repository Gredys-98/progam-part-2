using System;
using System.Globalization;


namespace diferentes_tipos_de_año
{
    class Program
    {
        static void Main()
        {
            int[] años = { 2021 };
            DateTimeFormatInfo dias = DateTimeFormatInfo.CurrentInfo;
            Console.WriteLine("\tdias del mes del año determinado "+
                              
                              CultureInfo.CurrentCulture.Name,
                              dias.Calendar.GetType().Name.Replace("Calendario", ""));
            Console.WriteLine("{0,-10}{1,-15}{2,4}\n", "años", "meses", "dias");

            foreach (var año in años)
            {
                for (int ctr = 0; ctr <= dias.MonthNames.Length - 1; ctr++)
                {
                    if (String.IsNullOrEmpty(dias.MonthNames[ctr]))
                        continue;

                    Console.WriteLine("{0,-10}{1,-15}{2,4}", año,
                                      dias.MonthNames[ctr],
                                      DateTime.DaysInMonth(año, ctr + 1));
                }
                Console.ReadKey ();
            }


        }
    }
}

