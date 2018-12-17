using System;

namespace CalculateAge
{
    class Program
    {

        

        enum Gender { M, F };
        

        static void Main(string[] args)
        {

            int year, month, day;
            int? gender;
            int yearToRetirement = 0;
            DateTime timeNow = DateTime.Now;
           
            

           

            Console.WriteLine("Please enter year between 1930 and 2018");
        RestartYear:
            String yearString = Console.ReadLine();
            if (Int32.TryParse(yearString, out year))
            {
                if (year < 1930 || year > 2018)
                {
                    Console.WriteLine("Please enter avalid year between 1930 and 2018");
                    goto RestartYear;
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto RestartYear;
            }



            Console.WriteLine("Please enter month between 1 an 12");
        RestartMonth:
            String monthString = Console.ReadLine();
            if (Int32.TryParse(monthString, out month))
            {
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Please enter a valid month between 1 and 12");
                    goto RestartMonth;
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto RestartMonth;
            }


            Console.WriteLine("Please enter day between 1 and 31");
        RestartDay:
            String dayString = Console.ReadLine();
            if (Int32.TryParse(dayString, out day))
            {
                if (day < 1 || day > 31)
                {
                    Console.WriteLine("Please enter e valid day number between 1 and 31");
                    goto RestartDay;
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto RestartDay;

            }

            DateTime birthdate = new DateTime(year, month, day);

            Console.WriteLine("Please enter a gender(M/F)");
            String genderString = Console.ReadLine();
            String male = "M";
            String female = "F";

            if (genderString.Equals(male))
            {
                gender = (int)Gender.M;
                yearToRetirement = 65 - (timeNow.Year - year);
                Console.WriteLine($"You were born in {birthdate.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("ro-RO")) } ");
                Console.WriteLine($"and you have {yearToRetirement} years to retire");

            }
            else if (genderString.Equals(female))
            {
                gender = (int)Gender.F;
                yearToRetirement = 63 - (timeNow.Year - year);
                Console.WriteLine($"You were born in {birthdate.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("ro-RO")) } ");
                Console.WriteLine($"and you have {yearToRetirement} years to retire");
            }
                else
            {
                gender = null;
            }

           

           

          

            Console.Read();




        }
    }
}
