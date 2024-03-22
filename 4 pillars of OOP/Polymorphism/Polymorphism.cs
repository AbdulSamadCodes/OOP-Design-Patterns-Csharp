//Polymorphism means many forms.This means all the child classes can have different impleemntation of the 
//method defined in base or parent class.
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The Animal is Barking");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat says meow");
    }
}

//Both Dog and Cat classes gave their own implementation of Sound method of parent class
class Polymorphism
{
    public static void Main(string[] args)
    {
        Dog germanShepherd = new Dog();
        germanShepherd.Sound();
        Cat persianCat = new Cat();
        persianCat.Sound();
    }
}