using System;

namespace CSharp1Exercises.ControlFlow
{
    public class ConditionalsDemo
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}








/*using System;

namespace Conditionals
{
public class Program
{
    static void Main(string[] args)
    {
    public void Excercise1()
    {
System.Console.WriteLine("Enter vaue here\n");  
string b = System.Console.ReadLine(); 
var a= Convert.ToInt32(b);
if(a>=1 && a<=10)
System.Console.WriteLine("Valid");
else
System.Console.WriteLine("Invalid");
    }  
}
}
}







/*public enum Season 
{
    Spring,
    Summer,
    Autumn,
    Winter
}

class Program
{
static void Main(string[] args)
{
}
}
}
  
  
  
  
   /* var season = Season.Autumn;
    switch(season)
    {
        case Season.Autumn:
        System.Console.WriteLine("Autumn");
        break;

        case Season.Summer:
        System.Console.WriteLine("Summer");
        break;

        default:
        System.Console.WriteLine("I dont know");
        break;


    }
}
}


}







/* 
            bool isGoldCustomer = true;
            float price;
           /* if(isGoldCustomer)
            price = 19.95f;
            else
            price = 29.95f; */

/*            price = (isGoldCustomer)? 19.95f:29.95f;
            System.Console.WriteLine(price);
            

            
        }
    }
}




/*using System;
using myapp.Math;
namespace myapp
{
}
public class Program
{
    static void Main(string[] args)
    {

    }
}
}


/*public class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        var b = a;
        b++;
        System.Console.WriteLine(string.Format("a: {0},b: {1}",a,b ));

var array1 = new int[3]{1,2,3};
var array2 = array1;
array2[0] = 0;
System.Console.WriteLine(string.Format("array1[0]: {0},array2[0]: {1}",array1[0],array2[0]));
    }
}
}




   /* public enum ShippingMethod
    {
        RegularAirmail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }
    public class Program
    
    {
        static void Main(string[] args)
        {
          var method = ShippingMethod.Express;
          System.Console.WriteLine(method);  

          var methodId = 1;
          System.Console.WriteLine((ShippingMethod)methodId);

          var MethodName = "RegisteredAirmail";
          var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),MethodName);
          System.Console.WriteLine(shippingMethod);
        }
    }
}
    
    


    /*class Program
    {
        static void Main(string[] args)
        {
            PersonDetails himaja = new PersonDetails();
            himaja.FirstName="Himaja";
            himaja.LastName="Akula";
            himaja.IntroduceMe();
            System.Console.WriteLine("------------BREAK----------------");
            Calculator calculator = new Calculator();
            var result = calculator.Add(1,3);
            System.Console.WriteLine(result);
            System.Console.WriteLine("------------BREAK----------------");
            int[] numbers = new int[3];
            numbers[0]=1;
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[2]);
            System.Console.WriteLine("------------BREAK----------------");
            string[] names = new string[2] {"h","i"};
            System.Console.WriteLine("------------BREAK----------------");
            string myname = "Himaja";
            char firstLetter = myname[4];
            System.Console.WriteLine(firstLetter);
            System.Console.WriteLine("------------BREAK----------------");
            string firstName = "Himaja";
            String lastName = "Akula";
            string fullName = string.Format("My name is {0},{1} ", firstName,lastName);
            var namesArr=new string[3]{"John","Jack","Mary"};
            var formattedNames = string.Join(",",namesArr);
            System.Console.WriteLine(formattedNames);
            System.Console.WriteLine("------------BREAK----------------");
            var text = @"Hi John,
            Look into the following paths
            C:\Users\Himaja
            C:\Users\Harish";
            System.Console.WriteLine(text);
        }
    }
 } */

 