using System;

namespace PrimusFoods
{
    public class Goods
    {
        string GoodsName { get; set; }
        public DateTime DateOfProduceEntry { get; private set; }
        public string ProductBatchNumber { get; private set; }
        int QuantityOfGoods { get; set; }
        string ProductsExpiryDate { get; set; }

        public Goods(string goodsName, int quantityOfGoods, string productsExpiryDate)
        {
            GoodsName = goodsName;
            QuantityOfGoods = quantityOfGoods;
            ProductBatchNumber = GenerateProductBatchNumber();
            DateOfProduceEntry = DateTime.Now;
            ProductsExpiryDate = productsExpiryDate;
        }

        private Goods(string goodsName, DateTime dateOfProduceEntry, string productBatchNumber, int quantityOfGoods)
        {
            GoodsName = goodsName;
            DateOfProduceEntry = dateOfProduceEntry;
            ProductBatchNumber = productBatchNumber;
            QuantityOfGoods = quantityOfGoods;
        }

        private string GenerateProductBatchNumber()
        {
            string goodsName = $"{GoodsName[0]}{GoodsName[1]}{GoodsName[2]}{GoodsName[3]}".ToUpper();
            string dateofentry = DateOfProduceEntry.ToShortDateString().Replace("/", "").Trim();
            return $"{goodsName}-{dateofentry}";
        }
        public override string ToString()
        {
            return $"{GoodsName}\t,   {QuantityOfGoods}\t,  {ProductBatchNumber}\t,   {DateOfProduceEntry}";
        }

        public static Goods ParseProductFromString(string SeparateContents)
        {
            string[] prodinfo = SeparateContents.Split("\t");
            return new Goods(prodinfo[0], DateTime.Parse(prodinfo[1]), prodinfo[2], int.Parse(prodinfo[3]));
        }

    }
}