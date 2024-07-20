using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class PlayerMoney : MonoBehaviour
    {
        public Observer<float> Money = new Observer<float>(100);

        void Start()
        {
            Money.Invoke();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Money.Value += 10;
            }
        }
    }
}