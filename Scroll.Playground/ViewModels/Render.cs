using Scroll.Playground.Models;

namespace Scroll.Playground.ViewModels
{
    public class Render<T>
    {
        public static Render<T> Model(T model) {

            return new Render<T>
            {
                Content = model
            };
            
        }

        public T Content { get; set; }
        public ERender RenderMode { get; private set; }

        public Render<T> As(ERender renderMode)
        {
            RenderMode = renderMode;
            return this;
        }
    }
}
