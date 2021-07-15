namespace Final_exercice.Entities
{
    class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healtExpenditures)
            : base(name, anualIncome)
        {
            HealtExpenditures = healtExpenditures;
        }

        public override double tax()
        {
            if (AnualIncome < 20000.00)
            {
                AnualIncome = AnualIncome * 0.15;
                if (HealtExpenditures > 0.0)
                {
                    return AnualIncome -= (HealtExpenditures / 2);
                }
            }
            else
            {
                AnualIncome = AnualIncome * 0.25;
                if (HealtExpenditures > 0.0)
                {
                    return AnualIncome -= (HealtExpenditures / 2);
                }
            }

            return AnualIncome;

        }
    }
}
