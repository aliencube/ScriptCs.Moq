using System.Reflection;

using Aliencube.ScriptCs.Moq.Tests.Fixtures;

using FluentAssertions;

using Moq;

using Xunit;

namespace Aliencube.ScriptCs.Moq.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="MoqPackContext"/> class.
    /// </summary>
    public class MoqPackContextTest : IClassFixture<MoqPackContextFixture>
    {
        private const string ConstructorArgumentsField = "constructorArguments";

        private readonly MoqPackContext _context;

        /// <summary>
        /// Initialises a new instance of the <see cref="MoqPackContextTest"/> class.
        /// </summary>
        /// <param name="fixture"><see cref="MoqPackContextFixture"/> instance.</param>
        public MoqPackContextTest(MoqPackContextFixture fixture)
        {
            this._context = fixture.MoqPackContext as MoqPackContext;
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_Type_Mock_ShouldReturn_DefaultResult()
        {
            var mocked = this._context.Mock<MyClass>();
            mocked.Behavior.Should().Be(MockBehavior.Loose);

            var fi = mocked.GetType().GetField(ConstructorArgumentsField, BindingFlags.Instance | BindingFlags.NonPublic);
            var args = fi.GetValue(mocked) as object[];
            args.Length.Should().Be(0);
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_Type_Mock_ShouldReturn_BehaviourResult()
        {
            var mocked = this._context.Mock<MyClass>(MockBehavior.Strict);
            mocked.Behavior.Should().Be(MockBehavior.Strict);

            var fi = mocked.GetType().GetField(ConstructorArgumentsField, BindingFlags.Instance | BindingFlags.NonPublic);
            var args = fi.GetValue(mocked) as object[];
            args.Length.Should().Be(0);
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_Type_Mock_ShouldReturn_ArgumentsResult()
        {
            var @params = new object[] { "abc", "xyz" };

            var mocked = this._context.Mock<MyClass>(@params);
            mocked.Behavior.Should().Be(MockBehavior.Loose);

            var fi = mocked.GetType().GetField(ConstructorArgumentsField, BindingFlags.Instance | BindingFlags.NonPublic);
            var args = fi.GetValue(mocked) as object[];
            args.Length.Should().Be(@params.Length);
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_Type_Mock_ShouldReturn_BehaviourAndArgumentsResult()
        {
            var @params = new object[] { "abc", "xyz" };

            var mocked = this._context.Mock<MyClass>(MockBehavior.Strict, @params);
            mocked.Behavior.Should().Be(MockBehavior.Strict);

            var fi = mocked.GetType().GetField(ConstructorArgumentsField, BindingFlags.Instance | BindingFlags.NonPublic);
            var args = fi.GetValue(mocked) as object[];
            args.Length.Should().Be(@params.Length);
        }
    }
}
