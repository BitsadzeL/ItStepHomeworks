using homework8.models;

namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hero superman = new Hero("Superman", 100, 150, 30);
            Hero batman = new Hero("Batman", 80, 120, 25);
            Villain zombie = new Villain("Joker", 50, 100, -35);

            zombie.Attack(superman);
            batman.Heal(superman, 20);

        }
    }



}
