using System.Collections.Generic;

namespace BackEnd_Project.DTOs
{
    public class ItemGrossPriceDTO
    {
        public IEnumerable<ItemDTO> Items{get;set;} = new List<ItemDTO> ();
        public decimal GrossTotalPrice{get;set;}
    }
}