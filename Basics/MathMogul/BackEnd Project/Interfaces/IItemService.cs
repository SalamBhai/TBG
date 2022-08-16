using System.Collections.Generic;
using BackEnd_Project.DTOs;
using BackEnd_Project.Entities;

namespace BackEnd_Project.Interfaces
{
    public interface IItemService
    {
          public string Create(CreateItem item);
         public bool Update(ItemUpdateRequestModel item, int id);
         public IEnumerable<ItemDTO> GetItems();
         public ItemDTO GetItem(int id);
         public bool Delete(int id);
         public decimal GrossTotalPriceOfItem();
    }
}