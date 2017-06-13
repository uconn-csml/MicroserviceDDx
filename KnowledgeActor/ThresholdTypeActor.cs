using KnowledgeActor.Interfaces;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace KnowledgeActor
{
    public class ThresholdTypeActor : KnowledgeActor
    {
        private double threshold;

        public double Threshold { get { return threshold; } set { this.threshold = value; } }
        public ThresholdTypeActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
        }
    }
}
