using UnityEngine;
using UnityEngine.UI;

namespace CodeArchitecture.Command
{
    public class RemoteControl : MonoBehaviour
    {
        RemoteControlSlotObject[] _remoteControlSlots;
        ICommand[] _onCommands;
        ICommand[] _offCommands;
        IDisplayElement[] _displayElements;
        ICommand _noCommand;

        void Awake() {
            _remoteControlSlots = GetComponentsInChildren<RemoteControlSlotObject>();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            _onCommands = new ICommand[]
            {
                new LightOnCommand(livingRoomLight),
                new LightOnCommand(kitchenLight)
            };
            _offCommands = new ICommand[]
            {
                new LightOffCommand(livingRoomLight),
                new LightOffCommand(kitchenLight)
            };
            _displayElements = new IDisplayElement[]
            {
                livingRoomLight,
                kitchenLight
            };
            _noCommand = new NoCommand();
            SetSlots();
        }

        void SetSlots() {
            for (int i = 0; i < _remoteControlSlots.Length; i++)
            {
                if (i < _onCommands.Length)
                    _remoteControlSlots[i].SetCommand(_onCommands[i], _offCommands[i], _displayElements[i].DisplayText);
                else
                {
                    _remoteControlSlots[i].SetCommand(_noCommand, _noCommand, "No Command");
                }
            }
        }
    }
}