

namespace Inheritance4.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual (double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if(HealthExpenditures > 0)
            {
                if (AnualIncome < 20000.00)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
                }
                else
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
            }
            else
            {
                if (AnualIncome < 20000.00)
                {
                    return AnualIncome * 0.15;
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}
