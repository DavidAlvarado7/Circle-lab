
using CIrcle_Objects;

Console.WriteLine("Hello, please enter a number radius.");
while (true)
{



    string userCircle = Console.ReadLine();
    if (double.TryParse(userCircle, out double number))
    {
        Circle circle = new Circle(number);
        Console.WriteLine(circle.GetDiameterOfCircle());
        Console.WriteLine(circle.GetAreaOfCircle());
        Console.WriteLine(circle.CalculateCircumference());

        Console.WriteLine("should the circle grow?");
        string answer = Console.ReadLine();
        while (true)
            if (answer == "Y")
            {
                Console.WriteLine("The circle is growing bruh");
                Console.WriteLine(circle.Grow);
                break;

            }




    }
    else
    {
        Console.WriteLine("Please, enter a valid number radius.");
    }

}

