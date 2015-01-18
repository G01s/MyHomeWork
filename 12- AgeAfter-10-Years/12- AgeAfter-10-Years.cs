using System;



    class _12__AgeAfter_10_Years
    {
        static void Main()
        {
            Console.WriteLine();
             Console.Write("My birthday date:  ");
        DateTime myBirthday = DateTime.Parse(Console.ReadLine());
 
        DateTime DateNow = DateTime.Now;
 
        var myAge = DateNow.Year - myBirthday.Year;
        Console.WriteLine("My age: " + myAge);
 
        var futureAge = myAge + 10;
        Console.WriteLine("My age after 10 years : " + futureAge);
           

        }
    }

