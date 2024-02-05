namespace PatternFactoryMethodsFitnessClub.Domain
{
    internal class GymMembership : IMembership
    {
        public readonly string name;
        private readonly decimal price;

        public GymMembership(decimal price)
        {
            this.name = "Gym membership";
            this.price = price;
        }

        public string Name => name;
        public string Description { get; set; }

        public decimal GetPrice() => price;
    }
}
