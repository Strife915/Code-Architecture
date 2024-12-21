using UnityEngine;

namespace CodeArchitecture.Iterator
{
    public class Waitress : MonoBehaviour
    {
        IMenu _pancakeHouseMenu;
        IMenu _dinerMenu;

        public Waitress() {
            _pancakeHouseMenu = new PancakeHouseMenu();
            _dinerMenu = new DinerMenu();
        }

        void Start() {
            PrintMenu();
        }

        public void PrintMenu() {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Debug.Log("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Debug.Log("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        void PrintMenu(IIterator iterator) {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Debug.Log(menuItem.Name + ", ");
                Debug.Log(menuItem.Price + " -- ");
                Debug.Log(menuItem.Description);
            }
        }
    }
}