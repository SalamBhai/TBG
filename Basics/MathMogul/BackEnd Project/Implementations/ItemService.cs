using System.Collections.Generic;
using System.Linq;
using BackEnd_Project.Context;
using BackEnd_Project.DTOs;
using BackEnd_Project.Entities;
using BackEnd_Project.Interfaces;

namespace BackEnd_Project.Implementations
{
    public class ItemService : IItemService
    { 
        private readonly IItemRepository _itemRepo;
        private readonly ApplicationContext appcontext;
         public ItemService(IItemRepository itemRepo, ApplicationContext _appCont)
         {
             _itemRepo= itemRepo;
             appcontext=_appCont;
         }
           public  string Create(CreateItem model)
           {
               var theItem = _itemRepo.GetItem(model.Name);
               if(theItem == null)
               {
                   var item = new Item
                   {
                       Name = model.Name,
                      UnitPrice= model.UnitPrice,
                      Quantity = model.Quantity,
                      TotalPrice =  ItemTotalPrice(model.UnitPrice,model.Quantity),
                    };
                     _itemRepo.Create(item);
                     return "";
               }
               var qty= theItem.Quantity += model.Quantity;
                theItem.TotalPrice = ItemTotalPrice(model.UnitPrice, qty);
                _itemRepo.SaveChanges();           
               return "Item Ready Exists";
           }
         public bool Update(ItemUpdateRequestModel item, int id)
         {
             var iteminDb =  _itemRepo.GetItem(id);
             iteminDb.Name =  item.Name;
             iteminDb.UnitPrice = item.UnitPrice;
             iteminDb.Quantity = item.Quantity;
             iteminDb.TotalPrice = ItemTotalPrice(item.UnitPrice, item.Quantity);
             _itemRepo.Update(iteminDb);
             return true;
         }
           public IEnumerable<ItemDTO> GetItems()
           {
             return _itemRepo.GetItems().Select(item=> new ItemDTO
               { 
                 Id =item.Id,
                   Name = item.Name,
                     UnitPrice= item.UnitPrice,
                  Quantity = item.Quantity,
                  TotalPrice= item.TotalPrice,
             }).ToList();
            }

         public ItemDTO GetItem(int id)
           {
             var viewItem= _itemRepo.GetItem(id);
             return new ItemDTO
               {
                   Id=viewItem.Id,
                     Name = viewItem.Name,
                     UnitPrice= viewItem.UnitPrice,
                  Quantity = viewItem.Quantity,
                  TotalPrice= viewItem.TotalPrice,
               };
            }
         public bool Delete(int id)
         {
             var itemtodelete= _itemRepo.GetItem(id);
           _itemRepo.Delete(itemtodelete);
           return true;
         }
           private decimal ItemTotalPrice(decimal unitprice, int Quantity)
            {
              decimal itemTQ =  unitprice * Quantity;
              return itemTQ;
            }
            public decimal GrossTotalPriceOfItem()
            {
              decimal GrossTotalPrice=0;
               foreach (var item in _itemRepo.GetItems())
               {
                  GrossTotalPrice+=item.TotalPrice;
               }
               return GrossTotalPrice;
            }

       
    }
}