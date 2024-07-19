using UnityEngine;

namespace CodeArchitecture.Mediator
{
    public class AgentMediator : Mediator<Agent>
    {
        protected override bool MediatorConditionMet(Agent target) => target.IsGreen;

        protected override void OnRegistered(Agent entity)
        {
            Debug.Log($"{entity.name} registered");
            BroadCast(entity, new MessagePayload { Content = "Registered" });
        }

        protected override void OnUnRegistered(Agent entity)
        {
            Debug.Log($"{entity.name} unregistered");
            BroadCast(entity, new MessagePayload { Content = "Unregistered" });
        }
    }
}