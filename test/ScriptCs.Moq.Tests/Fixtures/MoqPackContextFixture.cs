using System;

using Aliencube.ScriptCs.Moq;

using ScriptCs.Contracts;

namespace ScriptCs.Moq.Tests.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="MoqPackContextTest"/> class.
    /// </summary>
    public class MoqPackContextFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="MoqPackContextFixture"/> class.
        /// </summary>
        public MoqPackContextFixture()
        {
            this.MoqPackContext = new MoqPackContext();
        }

        /// <summary>
        /// Gets the <see cref="IScriptPackContext"/> instance.
        /// </summary>
        public IScriptPackContext MoqPackContext { get; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
