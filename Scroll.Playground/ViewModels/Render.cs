using Scroll.Playground.Models;

namespace Scroll.Playground.ViewModels
{
    /// <summary>
    /// Wraps any Model and provides a type (<see cref="ERender"/>)
    /// to decide how the model should be rendered.
    /// E.g. as content or menu
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Render<T>
    {
        public static Render<T> Model(T model)
        {
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
