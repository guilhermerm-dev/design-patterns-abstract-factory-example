using System;
namespace abstract_factory_example
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name +
        " eats " + herbivore.GetType().Name);
        }
    }
}
