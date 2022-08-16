using System.Collections.Generic;
using System.IO;

namespace PrimusFoods
{
    public class GoodsFileAffairs
    {
        string Path { get; set; }
        public GoodsFileAffairs(string path)
        {
            Path = path;
        }
        public void GoodsToFile(string Path, string ListOfProducts)//i.e Contents)
        {
            StreamWriter products = new StreamWriter(Path, true);
            using (products)
            {
                products.WriteLine(ListOfProducts);
                products.Flush();
            }
        }

        public IEnumerable<string> ReadFromFile(string Path)
        {
            StreamReader readproducts= new StreamReader(Path);
            using (readproducts)
            {
                 while(!readproducts.EndOfStream)
                 {
                    yield return  readproducts.ReadLine();
                 }
            }
        }
    }
}