using TMPro;
using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class PlayerStateDisplay : MonoBehaviour
    {
        TMP_Text _stateText;

        void Awake()
        {
            _stateText = GetComponent<TMP_Text>();
        }

        public void UpdateStateDisplay(bool isAlive)
        {
            _stateText.text = isAlive ? "Alive" : "Dead";
        }
    }
}