namespace Ukesoppgave_uke3;

public class VirtualPet
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Personality { get; private set; }


    public VirtualPet(string name, int age, string personality)
    {
        Name = name;
        Age = age;
        Personality = personality;
    }

    public string FeedPet(string food)
    {
        return FeedPet(food, false);
    }

    public string FeedPet(string food, bool isFavorite)  // Overload
    {
        if (food.ToLower() == "kylling")
        {
            return "Hurra, dette er det beste jeg vet! Tusen takk for maten!";
        }
        else
        {
            return "Takk for maten.";
        }
    }



}