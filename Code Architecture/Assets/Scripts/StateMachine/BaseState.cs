namespace CodeArchitecture.StateMachine
{
    public abstract class BaseState : IState
    {
        public virtual void Enter()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void Exit()
        {
        }
    }
}