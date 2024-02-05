using PatternFactoryMethodsFitnessClub.Domain;

namespace PatternFactoryMethodsFitnessClub.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
