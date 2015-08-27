using System.Collections.Generic;

namespace Scroll.Playground.Models
{
    public class DemoSection
    {
        public string Title { get; set; }
        public IList<Demo> Demos { get; set; }
    }
}