using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    string[] enemies = { "Zombie", "Alien", "Robot", "Boss", "Med" };

    int[] enemyNos = {1,3,5,6,8};

    int playerHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("First Enemy: " + enemies[0]);

        for (int i = 0; i < enemies.Length; i++)
        {
            Debug.Log("Enemy: " + i + ": " + enemies[i]);
        }

        foreach (string enemy in enemies)
        {
            AttackEnemy(enemy);
        }
        CheckPlayerHealth();
    }

    void AttackEnemy(string enemyName)
    {
        if (enemyName == "Med")
        {
            Debug.Log("Found a Med! Healing...");

            playerHealth += 20;

            Debug.Log("Player health is now " + playerHealth);
        }
        else
        {
            Debug.Log("Fighting" + enemyName + "...");

            playerHealth -= 20;

            Debug.Log("Player health is now " + playerHealth);
        }
    }
    
    void CheckPlayerHealth()
    {
        if (playerHealth > 50)
        {
            Debug.Log("Player is strong");
        }
        else if (playerHealth <= 50)
        {
            Debug.Log("Player is weak");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("Player is dead and Stop the game");
        }
    }

}
