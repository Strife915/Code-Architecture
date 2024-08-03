using UnityEngine;

namespace CodeArchitecture.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public interface IDisplayElement
    {
        string DisplayText { get; }
    }

    public class NoCommand : ICommand
    {
        public void Execute() {
            Debug.Log("No command to execute");
        }

        public void Undo() {
            Debug.Log("No command to undo");
        }
    }
}