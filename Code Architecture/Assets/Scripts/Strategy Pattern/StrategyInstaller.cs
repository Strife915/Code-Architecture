using Zenject;

namespace CodeArchitecture.Strategy
{
    public class StrategyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            FlyBehaviorInstaller();
            QuackBehaviorInstaller();
            DuckInstaller();
        }

        void FlyBehaviorInstaller()
        {
            Container.BindInterfacesAndSelfTo<FlyWithWings>().AsTransient();
            Container.BindInterfacesAndSelfTo<FlyNoWay>().AsTransient();
        }

        void QuackBehaviorInstaller()
        {
            Container.BindInterfacesAndSelfTo<RegularQuack>().AsTransient();
            Container.BindInterfacesAndSelfTo<Squeak>().AsTransient();
        }

        void DuckInstaller()
        {
            Container.Bind<MallardDuck>().AsTransient();
            Container.Bind<RubberDuck>().AsTransient();
        }
    }
}