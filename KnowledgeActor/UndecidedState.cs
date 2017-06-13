using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeActor
{
    class UndecidedState : State, IState
    {
        public UndecidedState(string output) : base(output)
        {
        }
    }
}
