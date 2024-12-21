using System;
using CodeArchitecture.Iterator;
using UnityEngine;

namespace CodeArchitecture.Composite
{
    public class WaitressComposite : MonoBehaviour
    {
        MenuComponent _allMenus;

        public void PrintMenu() {
            _allMenus.Print();
        }

        void Start() {
            InitializeAllMenus();
            PrintMenu();
            PrintVegetarianMenu();
        }

        void InitializeAllMenus() {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "DESSERT");

            _allMenus = new Menu("ALL MENUS", "All menus combined");
            _allMenus.Add(pancakeHouseMenu);
            _allMenus.Add(dinerMenu);
            _allMenus.Add(cafeMenu);
            _allMenus.Add(dessertMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));
            cafeMenu.Add(new MenuItem("Cappucino", "Espresso with steamed milk", true, 3.89));
            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust", true, 1.59));
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
        }

        public void PrintVegetarianMenu() {
            IIterator iterator = _allMenus.CreateIterator();
            Debug.Log("\nVEGETARIAN MENU\n----");
            while (iterator.HasNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Next();
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (System.NotImplementedException)
                {
                }
            }
        }
    }
}