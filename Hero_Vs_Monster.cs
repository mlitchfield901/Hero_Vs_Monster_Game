Random attack = new Random();
int damage = 0;
int heroHealth = 10;
int monsterHealth = 10;

do
{
    damage = attack.Next(1, 11);
    monsterHealth = monsterHealth - damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
    }
    else
    {
        damage = attack.Next(1, 11);
        heroHealth = heroHealth - damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monster wins!");
        }
    }
} while ((heroHealth > 0) && (monsterHealth > 0));
