using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeActor
{
    public class State2 : IState
    {
        public string Output { get; set; }

        public State2(string output)
        {
            this.Output = output;
        }
    }
}
