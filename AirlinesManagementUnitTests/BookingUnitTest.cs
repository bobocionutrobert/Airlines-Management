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

                ControllerBooking c = new ControllerBooking();

                output.WriteLine(c.ToString());
            }
          
        }
}
