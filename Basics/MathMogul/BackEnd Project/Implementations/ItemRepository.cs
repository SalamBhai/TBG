using System.Collections.Generic;
using  BackEnd_Project.DTOs;
using  BackEnd_Project.Context;
using  BackEnd_Project.Entities;
using BackEnd_Project.Interfaces;
using System.Linq;

namespace BackEnd_Project.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationContext _appContext;
        public ItemRepository(ApplicationContext context)
        {
            _appContext=context;
        }

        public Item Create(Item item)
        {
            _appContext.Items.Add(item);
            _appContext.SaveChanges();
            return item;
        }
         public Item Update( Item item)
         {
             _appContext.Items.Update(item);
             _appContext.SaveChanges();
             return item;
         }
         public IEnumerable<Item> GetItems()
         {
             return _appContext.Items.ToList();
         }
         public Item GetItem(int id)
         {
             return _appContext.Items.Find(id);
         }
         public Item GetItem(string Name)
         {
             return _appContext.Items.SingleOrDefault(It=> It.Name==Name);
         }
         public void Delete( Item item)
         {
             _appContext.Items.Remove(item);
             _appContext.SaveChanges();
         }
         public void SaveChanges()
         {
             _appContext.SaveChanges();
         }
    }
}