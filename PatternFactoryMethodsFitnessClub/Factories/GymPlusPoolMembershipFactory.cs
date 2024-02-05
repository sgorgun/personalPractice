using PatternFactoryMethodsFitnessClub.Domain;

namespace PatternFactoryMethodsFitnessClub.Factories
{
    internal class GymPlusPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal price;
        private readonly string description;

        public GymPlusPoolMembershipFactory(decimal price, string description)
        {
            this.price = price;
            this.description = description;
        }

        public override IMembership GetMembership()
        {
            GymPlusPoolMembership membership = new(price)
            {
                Description = description
            };

            return membership;
        }
    }
}
