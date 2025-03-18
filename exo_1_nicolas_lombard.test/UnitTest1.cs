namespace exo_1_nicolas_lombard.test
{
    //les années divisible par 400 sont bissextiles
    //celles divisible par 100, mais pas par 400 ne le sont pas
    // les années divisible par 4, mais pas par 100 le sont
    // les années qui ne sont pas divible par 4 ne le sont pas
    public class UnitTest1
    {
        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(12)]
        [InlineData(ushort.MaxValue - 3)]
        public void DivisiblePar4(ushort annee)
        {
            Assert.True(CalendrierGregorien.EstBissextile(annee));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(ushort.MaxValue)]
        public void NonDivisiblePar4(ushort annee)
        {
            Assert.False(CalendrierGregorien.EstBissextile(annee));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(12)]
        [InlineData(ushort.MaxValue - 3)]
        public void DivisiblePar4MaisPasPar100(ushort annee)
        {
            Assert.True(CalendrierGregorien.EstBissextile(annee));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(300)]
        [InlineData(500)]
        [InlineData(ushort.MaxValue)]
        public void DiviseblePar100MaisPasPar400(ushort annee)
        {
            Assert.False(CalendrierGregorien.EstBissextile(annee));
        }

        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        [InlineData(1200)]
        [InlineData(ushort.MaxValue - 335)]
        public void DivisiblePar400(ushort annee)
        {
            Assert.True(CalendrierGregorien.EstBissextile(annee));
        }
    }
}