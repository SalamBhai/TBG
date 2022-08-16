using  BackEnd_Project.DTOs;
using System.Collections.Generic;
using BackEnd_Project.Entities;
namespace BackEnd_Project.Interfaces
{
    public interface IItemRepository
    {
         public Item Create(Item item);
         public Item Update( Item item);
         public IEnumerable<Item> GetItems();
         public Item GetItem(int id);
         public void Delete( Item item);
          public Item GetItem(string Name);
           public void SaveChanges();
    }
}