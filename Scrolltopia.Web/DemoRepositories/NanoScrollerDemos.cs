using System.Collections.Generic;
using Scrolltopia.Web.Models;

namespace Scrolltopia.Web.DemoRepositories
{
    public class NanoScrollerDemos
    {
        public ControllerDemoCollection GetAll()
        {
            return new ControllerDemoCollection
            {
                ControllerName = "NanoScroller",
                Demos = new List<DemoSection>
                {
                    new DemoSection
                    {
                        Title = "Introduction",
                        Demos = new List<Demo>
                        {
                            new Demo {Title = "Start", ActionName = "Index"}
                        }
                    },
                    new DemoSection
                    {
                        Title = "Basic",
                        Demos = new List<Demo>
                        {
                        }
                    },
                    new DemoSection
                    {
                        Title = "Interaction",
                        Demos = new List<Demo>
                        {
                        }
                    },
                    new DemoSection
                    {
                        Title = "Dynamic DOM",
                        Demos = new List<Demo>
                        {
                        }
                    },
                    new DemoSection
                    {
                        Title = "Events",
                        Demos = new List<Demo>
                        {
                        }
                    }
                }
            };
        }
    }
}