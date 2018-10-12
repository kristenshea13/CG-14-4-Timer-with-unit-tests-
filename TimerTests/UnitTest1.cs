using System;
using Xunit;
using CG_14_4__Timer_with_unit_tests_;

namespace TimerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TotalMilliseconds_Hours()
        {
            //arrange
            string timeString = "1";


            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //assert

            Assert.Equal(3600000, milliseconds);
           

        }

        [Fact]
        public void TotalMilliseconds_Minutes()
        {
            //arrange
            string timeString = "0:1";

            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //assert
            Assert.Equal(60000, milliseconds);

        }

        [Fact]
        public void TotalMilliseconds_Seconds()
        {
            string timeString = "0:0:1";

            int milliseconds = SetTime.TotalMilliseconds(timeString);

            Assert.Equal(1000, milliseconds);


        }


        [Fact]
        public void TotalMilliseconds_Nonsense()
        {
            string timeString = "9&2.5";

            int milliseconds = SetTime.TotalMilliseconds(timeString);

            Assert.Equal(0, milliseconds);

        }

        

    }
}
