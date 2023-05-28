/*
Lag en konsoll applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr. 

Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre characteristics utenfra klassen. 

Lag funksjonalitet som gjør at man kan gi dyret mat, 
Bruk en overload til å gi en annen feedback til console dersom det er favorittmaten til dyret 
- f eks “Hurra dette er det beste jeg vet tusen takk for maten!” istedenfor f.eks “Takk for maten”. 
*/


namespace Ukesoppgave_uke3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeedPet();
        }


        static void FeedPet()
        {
            var dog = new VirtualPet(name:"Bingo", age:7, personality:"Tullete");

            Console.WriteLine($"Hva skal gi gi til {dog.Name}?");

            var userInput = Console.ReadLine();

            string feedback = dog.FeedPet(userInput);

            Console.WriteLine(feedback);
        }
    }
}