using System.Collections.Generic;
using Scrolltopia.Web.Models;

namespace Scrolltopia.Web.DemoRepositories
{
    public class SimplebarDemos
    {
        public ControllerDemoCollection GetAll()
        {
            return new ControllerDemoCollection
            {
                ControllerName = "Simplebar",
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
                            new Demo {Title = "Minimal", ActionName = "MinimalSetup"},
                            new Demo {Title = "Scrollbar", ActionName = "Scrollbar"},
                        }
                    },
                    new DemoSection
                    {
                        Title = "Interaction",
                        Demos = new List<Demo>
                        {
                            new Demo {Title = "TiggeringControls", ActionName = "TriggeringControls"}
                        }
                    },
                    new DemoSection
                    {
                        Title = "Dynamic DOM",
                        Demos = new List<Demo>
                        {
                            new Demo
                            {
                                Title = "Absolute Positioning",
                                ActionName = "ScrollInAbsoultePositionedContainers"
                            }
                        }
                    },
                    new DemoSection
                    {
                        Title = "Customizing",
                        Demos = new List<Demo>
                        {
                            new Demo {Title = "Use own styles", ActionName = "CustomizingScrollbar"},
                            new Demo
                            {
                                Title = "IE8 optimizations",
                                ActionName = "CustomizingScrollbar"
                            }
                        }
                    }
                }
            };
        }
    }
}