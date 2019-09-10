using AsyncExamples;
using Xunit;

namespace AsyncExamplesTests
{
    public partial class SaladTests
    {
        [Fact]
        public void SaladShouldHaveFiveLetters()
        {
            Salad.Make();          
            var salad = ReadSaladFile(); 
            Assert.Equal(5, salad.Length);
        }

        [Fact]
        public void CaesarSaladShouldHaveElevenLetters()
        {
            Salad.Make("Caesar");
            var salad = ReadSaladFile();
            Assert.Equal(11, salad.Length);
        }

        [Fact]
        public void SaladShouldNotBeScrambled()
        {
            Salad.Make();            
            var salad = ReadSaladFile();
            Assert.Equal("Salad", salad);
        }
    }
}
