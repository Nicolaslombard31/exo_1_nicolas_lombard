namespace exo_1_nicolas_lombard.test
{
    //les années divisible par 400 sont bissextiles
    //celles divisible par 100, mais pas par 400 ne le sont pas
    // les années divisible par 4, mais pas par 100 le sont
    // les années qui ne sont pas divible par 4 ne le sont pas
    public class UnitTest1
    {
        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        [InlineData(1200)]
        public void AnneesDivisiblePar400(int anneeBissextile)
        {
            // ETANT DONNE une années est bisextile
            // QUAND elle est divisible par 400
            var estBissectile = CalendrierGregorien.EstBissextile(anneeBissextile);
            // ALORS on obtient true
            Assert.True(estBissectile);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(401)]
        [InlineData(801)]
        public void AnneesNonDivisiblePar400(int anneeBissextile)
        {
            // ETANT DONNE une années n'est pas bisextile
            // QUAND elle est divisible par 400
            var estBissectile = CalendrierGregorien.EstBissextile(anneeBissextile);
            // ALORS on obtient false
            Assert.False(estBissectile);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(300)]
        public void AnneesDivisiblePar100MaisPas400(int anneeNonBissextile)
        {
            // ETANT DONNE une années n'est pas bisextile
            // QUAND elle est divisible par 100 mais pas par 400
            var estBissectile = CalendrierGregorien.NestPasBissextile(anneeNonBissextile);
            // ALORS on obtient true
            Assert.True(estBissectile);
        }

        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        [InlineData(1200)]
        public void AnneesNonDivisiblePar100MaisPar400(int anneeNonBissextile)
        {
            // ETANT DONNE une années est bisextile
            // QUAND elle est divisible par 400 mais pas par 100
            var estBissectile = CalendrierGregorien.NestPasBissextile(anneeNonBissextile);
            // ALORS on obtient false
            Assert.False(estBissectile);
        }
    }
}