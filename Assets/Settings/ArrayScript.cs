using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    string[] weapons = { "Sword", "Gun", "Bow" };

    int[] weapons2 = {1,2,3,3,8};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("First Weapon: " + weapons[0]);

        for (int i = 0; i < weapons.Length; i++)
        {
            Debug.Log("weapon: " + i + ": " + weapons[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
