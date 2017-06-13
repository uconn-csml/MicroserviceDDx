using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using Microsoft.ServiceFabric.Actors.Client;
using KnowledgeActor.Interfaces;

namespace KnowledgeActor
{

    [StatePersistence(StatePersistence.Persisted)]
    internal class KnowledgeActor : Actor
    {
        internal IState currentState;
        internal IState undecidedState;
        internal IState state1;
        internal IState state2;

        public KnowledgeActor(ActorService actorService, ActorId actorId)
            : base(actorService, actorId)
        {
        }

        protected override Task OnActivateAsync()
        {
            return null;
        }

    }
}
