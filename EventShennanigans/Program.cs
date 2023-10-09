using EventShennanigans;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
       /// Start in the class Mathmatics to see the creation and invocation of the events
       /// 
       /// This Program triggers the events and adds implementation that needs to happen
       /// when one is triggered. <summary>

    private static void Main(string[] args)
    {
        //define an instance of our mathmatics class
        Mathmatics _maths = new Mathmatics();
      
        //we add a method for what needs to happen when each of the events is triggered
        _maths.DivisibleBy3 += Triggered;
        _maths.DivisibleBy5 += Triggered2;
       
        //put some testdata in the instance
        _maths.NumberOne = 6;
        _maths.NumberTwo = 9;

        //execute the method we made to invoke the events
       _maths.CalculateSum();

    }


    //When the event is invoked, execute this code
    // notice the empty/unused object, Eventargs parameters
    private static void Triggered(object? sender, EventArgs e)
    {
        Console.WriteLine("The result is divisible by 3");
    }

    //When the action is invoked, execute this code
    // notice the output we get back from our Action<Int> and are able to use.
    private static void Triggered2(int output)
    {
        Console.WriteLine("The result is divisible by 5");
        Console.WriteLine($"the output is: {output}.");
    }

}