namespace SillyAnimals.Subjects
{
    class Animal:Subject
    {
        public Animal(string species, string presumedSelf) : base(species, presumedSelf) {}

        public override string PresentSelf()
        {
            return $"Le {Species} dit: \"Je suis un {PresumedSelf} !\"";
        }
    }
}
