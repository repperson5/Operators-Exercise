namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // exericse 1 complete
            int a = 17;
            int b = 4;

            int sum = a + b;//addition
            Console.WriteLine($"Sum: {sum}");

            int diff = a - b;//subtraction
            Console.WriteLine($"Difference: {diff}");

            int product = a * b;//multiplication
            Console.WriteLine($"Product: {product}");

            int qoutient = a / b;//division
            Console.WriteLine($"Qoutient: {qoutient}");

            int remainder = a % b; //result of modulus
            Console.WriteLine($"Remainder = {remainder}");

            Console.WriteLine($"a divided by b is {qoutient} and the remainder is {remainder}");
            Console.WriteLine();// this creates a space in the code to make it more readable


            // exercise 2 complete
            Console.WriteLine("What is the radius of your circle?");// this prints to the console as a question to your user
            var radius = double.Parse(Console.ReadLine()); //console.readline accepts input from the user and comes in as a string. since it's coming in as string, the method double.Parse will allow the string to be converted in a double (a non-integer number)

            double area= Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is {area}.");
            

            //thought exercise complete

        }
    }
}
