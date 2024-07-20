using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CodeArchitecture.Decorator
{
    public class CoffeServer : MonoBehaviour
    {
        [SerializeField] Button _orderButton, _houseBlendButton, _espressoButton, _mochaButton, _soyButton, _whipsButton;
        [SerializeField] TMP_Text _brewedBeverageText, _costText;
        IBeverage _currentBeverage;

        void Awake()
        {
            _orderButton.onClick.AddListener(BrewBeverage);
            _houseBlendButton.onClick.AddListener(BrewHouseBlend);
            _espressoButton.onClick.AddListener(BrewEspresso);
            _mochaButton.onClick.AddListener(AddMocha);
            _soyButton.onClick.AddListener(AddSoy);
            _whipsButton.onClick.AddListener(AddWhips);
        }

        void BrewEspresso()
        {
            _currentBeverage = new Espresso();
        }

        void BrewHouseBlend()
        {
            _currentBeverage = new HouseBlend();
        }

        void AddMocha()
        {
            _currentBeverage = new Mocha(_currentBeverage);
        }

        void AddSoy()
        {
            _currentBeverage = new Soy(_currentBeverage);
        }

        void AddWhips()
        {
            _currentBeverage = new Whips(_currentBeverage);
        }

        void BrewBeverage()
        {
            if (_currentBeverage == null)
            {
                Debug.Log("Please select a beverage first");
                return;
            }

            _brewedBeverageText.text = _currentBeverage.GetDescription();
            _costText.text = $"Cost: {_currentBeverage.GetCost()}";
        }
    }
}