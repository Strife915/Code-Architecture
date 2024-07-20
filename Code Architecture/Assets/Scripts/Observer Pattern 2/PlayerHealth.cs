using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    public class PlayerHealth : MonoBehaviour
    {
        public Observer<int> Health = new Observer<int>(100);

        void Start()
        {
            Health.Invoke();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Health.Value += 10;
            }
        }
    }
}