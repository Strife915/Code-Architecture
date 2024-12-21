using CodeArchitecture.Composite;
using UnityEngine;

namespace CodeArchitecture.Iterator
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool vegetarian, double price) {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override IIterator CreateIterator() {
            return new NullIterator();
        }

        public override void Print() {
            Debug.Log(" " + GetName());
            if (IsVegetarian())
            {
                Debug.Log("(v)");
            }

            Debug.Log(", " + GetPrice());
            Debug.Log("     -- " + GetDescription());
        }
    }
}