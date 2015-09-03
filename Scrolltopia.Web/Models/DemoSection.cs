using System.Collections.Generic;

namespace Scrolltopia.Web.Models
{
    public class DemoSection
    {
        public string Title { get; set; }
        public IList<Demo> Demos { get; set; }
    }
}