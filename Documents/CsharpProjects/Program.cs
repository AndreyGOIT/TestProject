// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Random random = new Random();
int current = random.Next(1, 11);
int herosHealth = 10;
int monsterHealth = 10;

do
{
    // Hero turn
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;
    if (monsterHealth <= 0) {
        Console.WriteLine("Monster was damaged and lost " + heroAttack + " health and now has " + monsterHealth + " health.");
        Console.WriteLine("Hero wins!");
        break;
    } 
    // Monster turn
    int monsterAttack = random.Next(1, 11);
    herosHealth -= monsterAttack;
    if (herosHealth <= 0) {
        Console.WriteLine("Hero was damaged and lost " + monsterAttack + " health and now has " + herosHealth + " health.");
        Console.WriteLine("Monster wins!");
        break;
    }

    
} while (herosHealth > 0 && monsterHealth > 0);

Console.WriteLine("Game Over");