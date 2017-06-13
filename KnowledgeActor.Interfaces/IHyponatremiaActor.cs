using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace KnowledgeActor.Interfaces
{

    public interface IHyponatremiaActor : IActor
    {
        string MakeTransition(double input);
    }
}
