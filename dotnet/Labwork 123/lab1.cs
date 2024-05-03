// Lab 1: Implementing Run Time Polymorphism
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

public class Polymorphism
{
    public static void run()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound();  // Outputs "The animal makes a sound"
        myDog.MakeSound();     // Outputs "The dog barks"
        myCat.MakeSound();     // Outputs "The cat meows"
    }
}