

Dog goodboy = new Dog("Good Boy");

Console.WriteLine($"Name: {goodboy.Name}; Level of happiness: {goodboy.LevelOfHappiness}");

while (goodboy.LevelOfHappiness < 5)
{
    goodboy.Bark();
}

goodboy.Wag();
Console.WriteLine($"Level of happiness: {goodboy.LevelOfHappiness}");

class Dog
    {
    public string Name;
    public int LevelOfHappiness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now!");
    }


    public void Bark()
    {
        LevelOfHappiness++;
        Console.WriteLine("Woof woof!");
       
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} starts wagging its tail.");
        Console.WriteLine("Whoosh-whoosh!");
    }
}

