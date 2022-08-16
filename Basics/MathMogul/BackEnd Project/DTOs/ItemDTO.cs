namespace BackEnd_Project.DTOs
{
    public class ItemDTO
    {
         public int Id {get;set;}
        public string Name {get;set;}
        public decimal UnitPrice{get;set;}
        public int Quantity {get;set;}
        public decimal TotalPrice{get;set;}
    }
    public class CreateItem
    {
        
        public string Name {get;set;}
        public decimal UnitPrice{get;set;}
        public int Quantity {get;set;}
    }
    public class ItemUpdateRequestModel
    {
        public string Name {get;set;}
        public decimal UnitPrice{get;set;}
          public int Quantity {get;set;}
    }
}