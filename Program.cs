// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Animal> animals = new List<Animal>();

Animal dog = new Animal { Name = "Fido", Age = 3, Color = "Brown", Type = "Dog", Sound = "Bark" };
Animal cat = new Animal { Name = "Whiskers", Age = 2, Color = "Gray", Type = "Cat", Sound = "Meow" };
Animal bird = new Animal { Name = "Tweety", Age = 1, Color = "Yellow", Type = "Bird", Sound = "Tweet" };
Animal pig = new Animal { Name = "Porky", Age = 4, Color = "Pink", Type = "Pig", Sound = "Oink" };
animals.Add(dog);
animals.Add(cat);
animals.Add(bird);
animals.Add(pig);

foreach (Animal animal in animals)
{
Console.WriteLine($"The {animal.Type} named {animal.Name} is {animal.Age} years old, {animal.Color} in color, and says {animal.Sound}.");
}

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public string Type { get; set; }
    public string Sound { get; set; }

}