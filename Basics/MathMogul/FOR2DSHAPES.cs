using System;

namespace MathMogul
{   
    public abstract class IFOR2DSHAPES
    {
         public  void UserMenurespect()
         {
             Console.WriteLine("Dear user please report to the menu to check for your choice on the options on the menu");

         }

         public void usertomedia()
         {
             Console.WriteLine("Please dear user kindly visit our social media pages to make submission of your suggestions to our social media handles via : TGB.MathMogul! Thank you! BineBot Loves you!");
         }
          
          public void PrintOperation(string Action,double value, string shape )
          {
              Console.WriteLine($" The {Action} of the....{shape}..... is {value}");
          }

          
    }
}