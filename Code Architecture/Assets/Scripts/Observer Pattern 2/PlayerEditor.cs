using UnityEditor;
using UnityEngine;

namespace CodeArchitecture.Observer_2
{
    [CustomEditor(typeof(PlayerHealth))]
    public class PlayerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            PlayerHealth playerHealth = (PlayerHealth)target;
            if (GUILayout.Button("Damage Player"))
            {
                playerHealth.Health.Value -= 10;
            }

            if (GUILayout.Button("Heal Player"))
            {
                playerHealth.Health.Value += 10;
            }
        }
    }
}