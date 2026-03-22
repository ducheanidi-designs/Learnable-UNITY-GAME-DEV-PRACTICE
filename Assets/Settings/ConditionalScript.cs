using UnityEngine;

public class ConditionalScript : MonoBehaviour
{
    public int playerHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerHealth > 70)
        {
            Debug.Log("Player is Healthy");
        }
        else if (playerHealth > 30)
        {
            Debug.Log("Player is injured");
        }
        else
        {
            Debug.Log("Player is critical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
