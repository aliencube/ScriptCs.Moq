using ScriptCs.Contracts;

namespace Aliencube.ScriptCs.Moq
{
    /// <summary>
    /// This represents the entity for script pack.
    /// </summary>
    public class ScriptPack : IScriptPack
    {
        /// <summary>
        /// Initialises reference assemblies.
        /// </summary>
        /// <param name="session"><see cref="IScriptPackSession"/> instance.</param>
        public void Initialize(IScriptPackSession session)
        {
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <returns>Returns the context.</returns>
        public IScriptPackContext GetContext()
        {
            return new MoqPackContext();
        }

        /// <summary>
        /// Terminates the script pack.
        /// </summary>
        public void Terminate()
        {
        }
    }
}
