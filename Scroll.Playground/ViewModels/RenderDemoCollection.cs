using Scroll.Playground.Models;

namespace Scroll.Playground.ViewModels
{
    public class RenderDemoCollection
    {
        public ControllerDemoCollection DemoCollection { get; set; }
        public ERender RenderType { get; set; }

        public RenderDemoCollection RenderAs(ERender renderType)
        {
            RenderType = renderType;
            return this;
        }
    }
}