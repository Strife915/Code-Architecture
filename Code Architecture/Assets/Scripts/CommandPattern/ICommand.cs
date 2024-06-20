namespace CodeArchitecture.Command
{
    public interface ICommand
    {
        void Execute();
    }
    public abstract class ClientCommand : ICommand
    {
        protected readonly IEntity _entity;

        protected ClientCommand(IEntity entity)
        {
            _entity = entity;
        }
        public abstract void Execute();
        public static T Create<T>(IEntity entity) where T : ClientCommand
        {
           return (T) System.Activator.CreateInstance(typeof(T), entity);
        }
    }
    public class FirstCommand : ClientCommand
    {
        public FirstCommand(IEntity entity) : base(entity)
        {
        }

        public override void Execute()
        {
            _entity.FirstCommand();
        }
    }
    public class SecondCommand : ClientCommand
    {
        public SecondCommand(IEntity entity) : base(entity)
        {
        }

        public override void Execute()
        {
            _entity.SecondCommand();
        }
    }
    public class ThirdCommand : ClientCommand
    {
        public ThirdCommand(IEntity entity) : base(entity)
        {
        }

        public override void Execute()
        {
            _entity.ThirdCommand();
        }
    }
}