using System.Collections.Generic;
using Scroll.Playground.Models;

namespace Scroll.Playground.DemoRepositories
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
