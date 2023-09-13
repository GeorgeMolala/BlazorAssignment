using Bunit;
using System;
using Xunit;

namespace Testing
{
    public class UnitTest1:TestContext
    {
        [Fact]
        public void Device()
        {
            var cut = RenderComponent<Device>(parameters => parameters
                 .Add(p => p.Numbers, 42)
                     .Add(p => p.Lines, lines)
   );
        }
    }
}
