using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimusFoods
{
    public class GoodsAffairs
    {
        GoodsFileAffairs GoodsFile= new GoodsFileAffairs(".\\GoodsFile.txt");
        static int EntriesCount;
        List<Goods> goodsstore= new List<Goods>();
        public GoodsAffairs()
        {
            
        }


        public void CreateGoodsEntry()
        {
            Console.WriteLine("Enter The Goods Name");
            string GoodsName= Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the Quantity of goods in letters");
            int QuantityOfGoods= int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the expiry date of these products");
             string ProductsExpiryDate= Console.ReadLine();

             Goods goods= new Goods(GoodsName,QuantityOfGoods,ProductsExpiryDate);
             goodsstore.Add(goods);
             Console.WriteLine($"{GoodsName} has been added successfully!");
             if(goodsstore.Count>0)
             {
                EntriesCount=goodsstore.Count+1;
             }  
        }

        public void FindGoodsInfo()
        {
            Console.WriteLine("Welcome! Please get the information of the good by Entering:  1. To find product by ProductBatchNumber\n 2.To find product by date");
            int choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Console.WriteLine("Please provide me with the batchnumber of the good you are in search of");
                string productBatchNumber= Console.ReadLine().Replace(" ", "");
                Findby1(productBatchNumber);
                break;

                case 2:
                Console.WriteLine("Enter the entry date of the product");
                string prodentrydate= Console.ReadLine().Replace(" ", "");
                Findby2(prodentrydate);
                break;
                
                default:
                Console.WriteLine("Trial error! Provide me with 1 or 2");
                break;
            }
        }

        private void Findby1(string productbatchNumber)
        {
           productbatchNumber= Console.ReadLine();
           var theproduct= from goods in goodsstore where goods.Equals(productbatchNumber) select goods; 
             // Tis is the use of a Linq to fetch some items in a data store of goodsstore  it brings te good that has the same productnumber as the indicategbatc number
             foreach(var product in theproduct)
             {
                 Console.WriteLine(theproduct.ToString());   
             }
        }

         private void Findby2(string prodentdate)
        {
         prodentdate= Console.ReadLine().Replace(" ", "");
          var theproduct= from goods in goodsstore where goods.DateOfProduceEntry.Equals($"{prodentdate}") select goods;
          foreach (var item in theproduct)
          {
              Console.WriteLine(theproduct.ToString());
          }
        }

        private void WriteToFile(Goods goods)
        {
            goodsstore.Add(goods);
            GoodsFile.GoodsToFile(".\\GoodsFile.txt")
        }
    }
}