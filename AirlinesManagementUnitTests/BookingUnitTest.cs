using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Airlines_Management.Controller;

namespace AirlinesManagementUnitTests
{
    public class BookingUnitTest
    {

        

            private ControllerBooking control;

            private readonly ITestOutputHelper output;

            public BookingUnitTest(ITestOutputHelper output)
            {



                control = new ControllerBooking();
                this.output = output;
            }
            [Fact]
            public void TestLoad()
            {
                control.load();

                ControllerBank c = new ControllerBank();

                output.WriteLine(c.ToString());
            }
            [Fact]
            public void TestUpdateDescription()
            {
                control.load();

                control.updateDescription(1, "update");

                Assert.Equal("update", control.bankById(1).Description);

            }
            [Fact]
            public void TestUpdateCode()
            {
                control.load();

                control.updateCode(1, "updatecode");

                Assert.Equal("updatecode", control.bankById(1).Code);

            }
        }
}
