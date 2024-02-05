namespace PatternFactoryMethodsFitnessClub.Domain
{
    internal class GymPlusPoolMembership : IMembership
    {
        public readonly string name;
        private readonly decimal price;

        public GymPlusPoolMembership(decimal price)
        {
            this.name = "Gym membership + Pool";
            this.price = price;
        }

        public string Name => name;
        public string Description { get; set; }

        public decimal GetPrice() => price;
    }
}
