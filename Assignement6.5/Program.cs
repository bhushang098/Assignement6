using System;

class Animal
{

    public virtual void animalSound()
    {

        Console.WriteLine("The animal makes a sound like Animals ");

    }

}

class Pig : Animal
{

    public override void animalSound()
    {

        Console.WriteLine("The pig says: wee wee");

    }

}

class Dog : Animal
{

    public override void animalSound()
    {

        Console.WriteLine("The dog says: bow Bow");

    }

}

class Program
{

    static void Main(string[] args)
    {

        Animal myAnimal = new Animal(); // Create a Animal object

        Pig myPig = new Pig(); // Create a Pig object

        Dog myDog = new Dog(); // Create a Dog object

        myAnimal.animalSound();

        myPig.animalSound();

        myDog.animalSound();

    }

}