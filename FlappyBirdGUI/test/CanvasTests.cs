using Flappy_Bird_GUI;
using System.Windows.Forms;
using Xunit;

namespace Flappy_Bird_Windows_Form.test
{
    
    public class CanvasTests
    {
        private readonly int gravity = 15;

        [Fact]
        public void TestJumpMechanism_SpaceKeyPressed_GravityIsNegative()
        {
            // Arrange
            var canvas = new Canvas();
            var keyEventArgs = new KeyEventArgs(Keys.Space);

            // Act
            canvas.spaceKeyDown(null, keyEventArgs); // Assuming this method is public for testing

            // Assert
            Assert.Equal(-15, gravity); // Assuming Gravity is a public property for testing
        }
    }
}
