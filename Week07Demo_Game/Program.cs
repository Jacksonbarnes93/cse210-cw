namespace Week07Demo_Game;

class Program
{
    static void Main(string[] args)
    {
        Warrior bob = new Warrior();
        bob.SwingSword();

        Mage marge = new Mage();
        marge.CastSpell();


        List<Character> characters = new List<Character>();
        characters.Add(bob);
        characters.Add(marge);

        foreach(Character c in characters)
        {
            c.Spawn();
        }


    }
}
