using Moq;

using ScriptCs.Contracts;

namespace Aliencube.ScriptCs.Moq
{
    /// <summary>
    /// This represents script pack context entity.
    /// </summary>
    public class MoqPackContext : IScriptPackContext
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Moq.Mock{T}"/> class.
        /// </summary>
        /// <typeparam name="T">Object type for mocking.</typeparam>
        /// <returns>Returns the <see cref="Moq.Mock{T}"/> instance created.</returns>
        public Mock<T> Mock<T>() where T : class
        {
            return new Mock<T>();
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Moq.Mock{T}"/> class.
        /// </summary>
        /// <typeparam name="T">Object type for mocking.</typeparam>
        /// <param name="behavior"><see cref="MockBehavior"/> instance.</param>
        /// <returns>Returns the <see cref="Moq.Mock{T}"/> instance created.</returns>
        public Mock<T> Mock<T>(MockBehavior behavior) where T : class
        {
            return new Mock<T>(behavior);
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Moq.Mock{T}"/> class.
        /// </summary>
        /// <typeparam name="T">Object type for mocking.</typeparam>
        /// <param name="behavior"><see cref="MockBehavior"/> instance.</param>
        /// <param name="args">List of arguments.</param>
        /// <returns>Returns the <see cref="Moq.Mock{T}"/> instance created.</returns>
        public Mock<T> Mock<T>(MockBehavior behavior, params object[] args) where T : class
        {
            return new Mock<T>(behavior, args);
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Moq.Mock{T}"/> class.
        /// </summary>
        /// <typeparam name="T">Object type for mocking.</typeparam>
        /// <param name="args">List of arguments.</param>
        /// <returns>Returns the <see cref="Moq.Mock{T}"/> instance created.</returns>
        public Mock<T> Mock<T>(params object[] args) where T : class
        {
            return new Mock<T>(args);
        }
    }
}
