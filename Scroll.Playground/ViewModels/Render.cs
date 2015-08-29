using Scroll.Playground.Models;

namespace Scroll.Playground.ViewModels
{
    /// <summary>
    /// Wraps any Model and provides a mode (<see cref="ERender"/>)
    /// to decide how the model should be rendered.
    /// E.g. as content or menu
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Render<T>
    {
        /// <summary>
        /// Initializes Render with a model.
        /// </summary>
        /// <param name="model">The model that should be rendered</param>
        /// <returns>new instance of Render</returns>
        public static Render<T> Model(T model)
        {
            return new Render<T>
            {
                Content = model
            };
        }

        /// <summary>
        /// Instance of the model that should be rendered
        /// </summary>
        public T Content { get; set; }

        /// <summary>
        /// The current render mode used to decide which
        /// template should be applied to the model
        /// </summary>
        public ERender RenderMode { get; private set; }

        /// <summary>
        /// Configures the render mode for the model
        /// </summary>
        /// <param name="renderMode">the desired render mode</param>
        /// <returns>instance of Render</returns>
        public Render<T> As(ERender renderMode)
        {
            RenderMode = renderMode;
            return this;
        }
    }
}
