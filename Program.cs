namespace Superheroes
{
    internal class Program
    {
        // Creating a super hero, setting information, and outputting attribute data.
        static void Main()
        {
            SuperHero superPerson = new SuperHero();

            superPerson.SetIdentity("John Doe");

            superPerson.alias = "Super Person";

            superPerson.powers.AddRange(new[] {"Teleportation",
                                               "Shockwave",
                                               "Telekinesis"});
            superPerson.mask = "Neon Eyes";
            superPerson.costume = "White Cloak";

            superPerson.moralCode.AddRange(new[] {"Avoid harm if possible",
                                                  "Taking the life of your enemies makes you as bad as the enemy",
                                                  "Respect everyone"});

            superPerson.enemies.AddRange(new[] { "Shadow Sovereign",
                                                 "Vortex Marauder",
                                                 "Chaos Weaver" });

            superPerson.AddPersonalIssues(new[] {"Parents passed away when younger",
                                                 "Uncle recently passed away",
                                                 "Love of their life targeted by a villain"});

            Console.WriteLine($"Hero information:\n\n{superPerson.GetHeroInformation()}");

            Console.ReadKey();
        }
    }
}