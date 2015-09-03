using System.Collections.Generic;

namespace Scrolltopia.Web.Models
{
    public class ControllerDemoCollection
    {
        public string ControllerName { get; set; }
        public IList<DemoSection> Demos { get; set; }
    }
}