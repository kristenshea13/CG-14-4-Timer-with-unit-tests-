using CG_14_4__Timer_with_unit_tests_;
using Xunit;

namespace TimerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TotalMilliseconds_Hours()
        {
            //create initial string of hours to plug into program to test
            //arrange
            string timeString = "1";

            //put into method
            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //correct answer versus method answer.
            //assert
            Assert.Equal(3600000, milliseconds);
        }

        [Fact]
        public void TotalMilliseconds_HoursIncorrect()
        {
            //incorrect answer compared to method answer. designed to fail.
            //create initial string of hours to plug into program to test
            //arrange
            string timeString = "1";

            //put into method
            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //incorrect answer versus method answer.
            //assert
            Assert.Equal(3600011, milliseconds);
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
        public void TotalMilliseconds_MinutesIncorrect()
        {
            //incorrect answer. test will fail.
            //arrange
            string timeString = "0:1";

            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //incorrect answer vs method answer
            //assert
            Assert.Equal(60019, milliseconds);
        }

        [Fact]
        public void TotalMilliseconds_Seconds()
        {
            //arrange
            string timeString = "0:0:1";

            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //assert
            Assert.Equal(1000, milliseconds);
        }

        [Fact]
        public void TotalMilliseconds_SecondsIncorrect()
        {
            //incorrect answer, test will fail.
            //arrange
            string timeString = "0:0:1";

            //act
            int milliseconds = SetTime.TotalMilliseconds(timeString);

            //assert
            Assert.Equal(1005, milliseconds);
        }

        [Fact]
        public void TotalMilliseconds_Nonsense()
        {
            string timeString = "9&2.5";

            int milliseconds = SetTime.TotalMilliseconds(timeString);

            Assert.Equal(0, milliseconds);
        }

        [Fact]
        public void TotalMilliseconds_Nonsense_CorrectFormat()
        {
            //will not return 0 since time is in correct format. test will fail.
            string timeString = "1:1:36";

            int milliseconds = SetTime.TotalMilliseconds(timeString);

            Assert.Equal(0, milliseconds);
        }
    }
}