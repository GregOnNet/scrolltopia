using System.Collections.Generic;
using Scroll.Playground.Models;

namespace Scroll.Playground.DemoRepositories
{
    public class IscrollDemos
    {
        public ControllerDemoCollection GetAll()
        {
            return new ControllerDemoCollection
            {
                ControllerName = "IScroll",
                Demos = new List<DemoSection>
                {
                    new DemoSection
                    {
                        Title = "Introduction",
                        Demos = new List<Demo>
                        {
                            new Demo { Title= "Start", ActionName = "Index"}
                        }
                    },
                    new DemoSection
                    {
                        Title = "Basic",
                        Demos = new List<Demo>
                        {
                            new Demo { Title="Minimal", ActionName = "MinimalSetup"},
                            new Demo { Title="Clickable elements", ActionName = "ClickableElements"},
                            new Demo { Title="Displaying scrollbar", ActionName = "Scrollbar"},
                            new Demo { Title="Fading scrollbar", ActionName = "FadingScrollbar"},
                            new Demo { Title="Shrinked scrollbar", ActionName = "ShrinkedScrollbar"},
                            new Demo { Title="Decelerating scrollbar", ActionName = "Deceleration"}
                        }
                    },
                    new DemoSection
                    {
                        Title = "Interaction",
                        Demos = new List<Demo>
                        {
                            new Demo { Title="Interactive scrollbar", ActionName = "InteractiveScrollbar"},
                            new Demo { Title="Trigger scrolling", ActionName = "TriggeringControls"},
                        }
                    },
                    new DemoSection
                    {
                        Title = "Dynamic DOM",
                        Demos = new List<Demo>
                        {
                            new Demo { Title="Resizing scrolling content", ActionName = "ResizingScrollingContent"},
                            new Demo { Title="Animating scrolling content", ActionName = "AnimatedScrollingContent"},
                        }
                    },
                    new DemoSection
                    {
                        Title = "Events",
                        Demos = new List<Demo>
                        {
                            new Demo { Title="onScroll", ActionName = "HandleScrollEvents"},
                        }
                    }
                }
            };
        }
    }
}
