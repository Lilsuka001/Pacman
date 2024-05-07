private static void MoveEnemyTowardsPacman(ref int enemyX, ref int enemyY, int pacmanX, int pacmanY)
{
    // Random chance to move in a random direction (25% chance)
    Random random = new Random();
    int randomChance = random.Next(0, 4); // Generate a random number between 0 and 3

    if (randomChance == 0) // 25% chance
    {
        // Randomly choose a direction
        int randomDirection = random.Next(0, 4);

        switch (randomDirection)
        {
            case 0: // Up
                if (enemyY > 0)
                    enemyY--;
                break;
            case 1: // Down
                if (enemyY < map.GetLength(1) - 1)
                    enemyY++;
                break;
            case 2: // Left
                if (enemyX > 0)
                    enemyX--;
                break;
            case 3: // Right
                if (enemyX < map.GetLength(0) - 1)
                    enemyX++;
                break;
        }
    }
    else // Otherwise, move towards Pacman
    {
        if (enemyX < pacmanX)
            enemyX++;
        else if (enemyX > pacmanX)
            enemyX--;

        if (enemyY < pacmanY)
            enemyY++;
        else if (enemyY > pacmanY)
            enemyY--;
    }
}
