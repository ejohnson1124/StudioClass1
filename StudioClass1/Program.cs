namespace StudioClass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double radius;
            double area;
            double circumference;
            double diameter;
            double mpg;
            double gas;
            string input;
            string input2;

            Console.WriteLine("What is the radius of your circle?");
            input = Console.ReadLine();
            radius = double.Parse(input);

            area = pi * radius * radius;
            Console.WriteLine("The area of your circle is " + area);
            Console.ReadLine();

            circumference = 2 * pi * radius;
            Console.WriteLine("The circumference of your circle is " + circumference);  
            Console.ReadLine();

            diameter = pi * radius;
            Console.WriteLine("the diameter of your circle is "+diameter);
            Console.ReadLine();

            Console.WriteLine("how many mpg does your car get?");
            input2 = Console.ReadLine();
            mpg = double.Parse(input2);

            gas = diameter / mpg;
            Console.WriteLine("You will need " + gas + "gallons to drive around this circle.");
            Console.ReadLine();


        }
    }
}