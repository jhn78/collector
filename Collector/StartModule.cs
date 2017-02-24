using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector
{
    public class StartModule : NancyModule
    {
        public StartModule()
        {
            Get["/"] = parameters => "Hello World, this is my collection";
        }        
    }
}
