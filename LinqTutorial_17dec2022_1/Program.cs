namespace LinqTutorial_17dec2022_1;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };

        var areAllLargerThanZero = numbers.All(number => number > 0);
        Console.WriteLine($"{nameof(areAllLargerThanZero)}: { areAllLargerThanZero}");

        var pets = new[]
        {
            new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            new Pet(2, "Anthony", PetType.Cat, 2f),
            new Pet(3, "Ed", PetType.Cat, 0.7f),
            new Pet(4, "Taiga", PetType.Dog, 35f),
            new Pet(5, "Rex", PetType.Dog, 40f),
            new Pet(6, "Lucky", PetType.Dog, 5f),
            new Pet(7, "Storm", PetType.Cat, 0.9f),
            new Pet(8, "Nyan", PetType.Cat, 2.2f)
        };

        var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));
        Console.WriteLine($"{nameof(doAllHaveNonEmptyNames)}: {doAllHaveNonEmptyNames}");

        var areAllCats = pets.All(pet => pet.Type == PetType.Cat);
        Console.WriteLine($"{nameof(areAllCats)}: {areAllCats}");

    }
}