using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    string[] enemy = { "Oria", "Posion", "Ojuju", "med" };

    int[] enemyNos = {1,3,5,6,8};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("First Enemy: " + enemy[0]);

        for (int i = 0; i < enemy.Length; i++)
        {
            Debug.Log("Enemy: " + i + ": " + enemy[i]);
        }
    }

}
