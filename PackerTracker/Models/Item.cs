using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class Item
    {
        public string Name { get; set; }
        public bool Packed { get; set; }
        public bool Purchased { get; set; }
        public int Weight { get; set; }

        public int Id { get; }
        private static List<Item> _instances = new List<Item> { };
        public Item(string name, bool packed, bool purchased, int weight)
        {
            Name = name;
            Packed = packed;
            Purchased = purchased;
            Weight = weight;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}