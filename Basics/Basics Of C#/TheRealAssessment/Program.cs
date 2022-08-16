using System;

namespace TheRealAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Console.WriteLine("Program For Two Integers To Display sum, Product, difference and division");
            Console.WriteLine("Enter First Integer");
            int integer1= int.Parse(Console.ReadLine());
            Console.WriteLine("Second Integer");
            int integer2= int.Parse(Console.ReadLine());
            double addition= integer1+integer2;
            double product= integer1*integer2;
            double difference= integer1-integer2;
            double division= integer1/integer2;

            Console.WriteLine($"Addition of both Integers is {addition}, product is {product}  difference is{difference}, and its  quotient is{division}");*/

            //Question 2//
           /* Console.WriteLine("Program For calculation of sum, average, product, smallest, and largest number of Given Three Integers");
            Console.WriteLine("Enter First Integer");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Second Integer");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine("Third Integer");
            int c= int.Parse(Console.ReadLine());
            double addition= a+b+c;
            double average= a+b+c/3;
            double product= a*b*c;

            Console.WriteLine($"Addition of both Integers is {addition}, average is {average}, while the product is: {product}");
            
            if(a>b && a>c)
            {
             Console.WriteLine(" a is the largest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(" B is The Largest");
            }
            else if(c>a && c>b)
            {
                Console.WriteLine("The Largest number is C");
            }
            else
            {
                Console.WriteLine("What You Inputed is None of The Possible Values");
            }
            Console.ReadKey();

            if(a<b && a<c)
            {
             Console.WriteLine(" a is the smallest");
            }
            else if(b<a && b<c)
            {
                Console.WriteLine(" B is The smallest");
            }
            else if(c<a && c<b)
            {
                Console.WriteLine("The smallest number is C");
            }
            else
            {
                Console.WriteLine("What You Inputed is None of The Possible Values!");
            }
            Console.ReadKey();*/
           
           //Question 3//
         /*
           Console.WriteLine("Program to compare the equality of two integers the larger, display is larger for the larger number, while, is equal if numbers are equal");
           Console.WriteLine("Input Integer 1 ");
           int a= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Integer 2");
           int b= int.Parse(Console.ReadLine());

           if(a>b && b>a )
           {
               Console.WriteLine("a is the larger number");
           }
          
          else if(a==b && b==a)
          {
              Console.WriteLine("These Numbers Are Equal!");
          }
          else
          {
            Console.WriteLine("Nothing To Display!");
          }
          Console.ReadKey();
          
          //Question 4//
            /*Console.WriteLine(" Program To Display The Squares and cubes of 10 Numbers");
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine($"{i*i}       {i*i*i}");
            }*/

           
    
          /* //Question 5//
         Console.WriteLine("Program To Ccalculate The Volume and area of A Cylinder");

           Console.WriteLine("Calculate For the Radius");
           int radius= int.Parse(Console.ReadLine());

           Console.WriteLine(" Make Solution For Length Of The Cylinder");
           int length= int.Parse(Console.ReadLine());

           Console.WriteLine("Calculate Area Taking Formula To Be Radius*radius pie, take pie to be; 3.142");
           double area= radius* radius *3.142 ;

           Console.WriteLine("Calculate volume Taking Formula To Be area*length");
           double volume= area*length; 
           
           Console.WriteLine($"The calculation of the area is {area}cm^2 and its Volume is {volume}cm^3 ");*/

           //Question 7//

         /* Console.WriteLine("app that reads an integer, determines,and displays if even or odd");

           Console.WriteLine("Enter Number"); 
           int integer= int.Parse(Console.ReadLine());


           if(integer%2==0)
           {
               Console.WriteLine("The Number Is Even");
           }
           else if(integer%2==1)
           {
               Console.WriteLine("The Number Is odd");
           }
           else
           {
               Console.WriteLine("Nothing To Show!");
           }*/


           //Question 6
         
           /* Console.WriteLine("Program 6 ");

           Console.WriteLine("Provide a number in feet");
           double feet= Convert.ToDouble(Console.ReadLine());
           double meter= feet*0.305;
           Console.WriteLine($"Conversion of feet into meters is equal to{meter}");*/
         


          //Question 9
        /* Console.WriteLine("An App that Reads Two Integers and determines if number is");
          Console.WriteLine("Enter InteGer 1");
          int a= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Integer 2");
           int b= int.Parse(Console.ReadLine());

          if(a%b==0)
         {
           Console.WriteLine("The First Number is A Multiple Of The Second");
         }
         else
         {
          Console.WriteLine("The number is not a multiple of the second!");
         }*/

         
         Console.WriteLine("C# App That inputs a series of 10 integers And Determines And Then Displays The Largest");
         int largest=0;
          for(int counter=0;counter<=10;counter++)
          {
             Console.WriteLine("enter number");
              
             int number=int.Parse(Console.ReadLine());
          
            if( number > largest)
            {
             largest= number;
            }
          } Console.WriteLine($"The Largest Of The Ten Integers Is : {largest}");  


          //Question 8
         /*
          int occurences=0;
          int largest=0;
          int a=1;
          while (a >0)
          {
            Console.WriteLine("Enter Number");
             int num=int.Parse(Console.ReadLine());

             if(num==0)
             {
               break;
             }
             if(num>largest)
             {
               largest=num;
               occurences=1;
             }
             else if(largest==num)
             {
              occurences++;
             }

          } Console.WriteLine( $"The largest is {largest} with {occurences} number of occurences");*/
        
        
        }    
     
    }      
}
