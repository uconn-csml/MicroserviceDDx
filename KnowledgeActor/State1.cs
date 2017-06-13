using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeActor
{
    class State1 : State, IState
    {
        public State1(string output) : base(output)
        {
        }
    }
}
