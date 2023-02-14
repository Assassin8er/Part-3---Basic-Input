namespace Part_3___Basic_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cashmoney
            string lastname, firstname;
            double km1, km2, km3, average, leg1, leg2, hypotenuse;
            int curyear, birth, age, addtotal, add1, add2, add3;
            Console.WriteLine("Input current year:");
            curyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your age:");
            age = Convert.ToInt32(Console.ReadLine());
            birth = curyear - age;
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Your name is " + firstname + " " + lastname);
            Console.WriteLine("The current year is: " + curyear);
            Console.WriteLine("Your age is " + age + " and you were born in " + birth);
            Console.WriteLine("");
            Console.WriteLine("Write 3 numbers for me to total");
            Console.WriteLine("Input first number:");
            add1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            add2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number:");
            add3 = Convert.ToInt32(Console.ReadLine());
            addtotal = add1 + add2 + add3;
            Console.WriteLine("Your total is: " + addtotal);
            Console.WriteLine("");
            Console.WriteLine("Put in three distances in Km(may include decimals)");
            Console.WriteLine("Input first number:");
            km1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input second number:");
            km2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input third number:");
            km3 = Convert.ToDouble(Console.ReadLine());
            average = (km1 + km2 + km3)/3;
            Console.WriteLine("Your Average Is:");
            Console.WriteLine(Math.Round(average, 2));
            Console.WriteLine("");
            Console.WriteLine("Im to calculate the hypotenuse of a right angle triangle");
            Console.WriteLine("Input first leg value:");
            leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input second leg value:");
            leg2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(leg1, 2) + (Math.Pow(leg2, 2)));
            hypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine("The hypotenuse is " + hypotenuse);

        }
    }
}