using UnityEngine;

namespace CodeArchitecture.Command
{
    public class CommandClient : MonoBehaviour , IEntity
    {

        public void FirstCommand()
        {
            Debug.Log("First Command Executed!"); 
        }

        public void SecondCommand()
        {
            Debug.Log("Second Command Executed!");
        }

        public void ThirdCommand()
        {
            Debug.Log("Third Command Executed!"); 
        }
    }
}

