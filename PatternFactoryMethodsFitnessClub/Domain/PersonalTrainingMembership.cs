namespace PatternFactoryMethodsFitnessClub.Domain
{
    internal class PersonalTrainingMembership : IMembership
    {
        public readonly string name;
        private readonly decimal price;

        public PersonalTrainingMembership(decimal price)
        {
            this.name = "Persanal training membership ";
            this.price = price;
        }

        public string Name => name;
        public string Description { get; set; }

        public decimal GetPrice() => price;
    }
}
