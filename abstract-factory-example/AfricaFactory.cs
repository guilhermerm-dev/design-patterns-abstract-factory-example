namespace abstract_factory_example
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
