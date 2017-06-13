using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeActor
{
    class State
    {
        private string stateVariable;

        public string Output { get { return this.stateVariable; } set { this.stateVariable = value; } }

        public State(string output)
        {
            this.Output = output;
        }
    }
}
