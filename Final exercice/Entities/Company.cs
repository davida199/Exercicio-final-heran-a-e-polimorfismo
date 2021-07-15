namespace Final_exercice.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            if (NumberOfEmployees < 10)
            {
                AnualIncome = AnualIncome * 0.16;

            }
            else
            {
                AnualIncome = AnualIncome * 0.14;

            }

            return AnualIncome;
        }
    }
}
