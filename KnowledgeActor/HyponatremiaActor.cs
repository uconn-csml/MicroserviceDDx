using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using KnowledgeActor.Interfaces;

namespace KnowledgeActor
{
    class HyponatremiaActor : ThresholdTypeActor, IHyponatremiaActor
    {
        public HyponatremiaActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
            undecidedState = new UndecidedState("Unknown");
            state1 = new State1("Hyponatremia");
            state2 = new State2("Not hyponatremia");
            currentState = undecidedState;
            Threshold = 120;
        }

        public void MakeTransition(double input)
        {
            if (input <= Threshold)
            {
                this.currentState = state1;
            } else
            {
                this.currentState = state2;
            }
        }
    }
}
