using System.Collections.Generic;
using CodeArchitecture.Iterator;
using UnityEngine;

namespace CodeArchitecture.Composite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> _menuComponents = new List<MenuComponent>();
        IIterator _iterator = null;
        string _name;
        string _description;

        public Menu(string name, string description) {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent) {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent) {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i) {
            return _menuComponents[i];
        }

        public override string GetName() {
            return _name;
        }

        public override string GetDescription() {
            return _description;
        }

        public override void Print() {
            Debug.Log("\n" + GetName());
            Debug.Log(", " + GetDescription());
            Debug.Log("---------------------");

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                IIterator iterator = menuComponent.CreateIterator();
                while (iterator.HasNext())
                {
                    MenuComponent component = (MenuComponent)iterator.Next();
                    component.Print();
                }
            }
        }

        public override IIterator CreateIterator() {
            if (_iterator == null)
            {
                _iterator = new CompositeIterator(_iterator);
            }

            return _iterator;
        }
    }
}