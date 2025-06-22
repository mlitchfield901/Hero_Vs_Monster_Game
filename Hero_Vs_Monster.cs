//variale initialization
Random attack = new Random();
int damage = 0;
int heroHealth = 10;
int monsterHealth = 10;

// loop creation in order to continue the battle until a winner is determined
do
{
    // determine damage to monster using a random number generated between the values of 1 through 10)
    damage = attack.Next(1, 11);
    monsterHealth = monsterHealth - damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
    
    // Determine if Monster is defeated
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
    }
    else
    {
        // determine damage to hero using a random number generated between the values of 1 through 10)
        damage = attack.Next(1, 11);
        heroHealth = heroHealth - damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
        
        //Determine if ero is defeated
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monster wins!");
        }
    }
} while ((heroHealth > 0) && (monsterHealth > 0));
