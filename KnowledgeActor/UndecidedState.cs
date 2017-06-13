using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeActor
{
    class UndecidedState : IState
    {
        public string Output { get; set; }

        public UndecidedState(string output)
        {
            this.Output = output;
        }
    }
}
