using PatternFactoryMethodsFitnessClub.Domain;

namespace PatternFactoryMethodsFitnessClub.Factories
{
    internal class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal price;
        private readonly string description;

        public GymMembershipFactory(decimal price, string description)
        {
            this.price = price;
            this.description = description;
        }

        public override IMembership GetMembership()
        {
            GymMembership membership = new(price)
            {
                Description = description
            };

            return membership;
        }
    }
}
