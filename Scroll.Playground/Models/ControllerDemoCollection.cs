using System.Collections.Generic;

namespace Scroll.Playground.Models
{
    public class ControllerDemoCollection
    {
        public string ControllerName { get; set; }
        public IList<DemoSection> Demos { get; set; }
    }
}