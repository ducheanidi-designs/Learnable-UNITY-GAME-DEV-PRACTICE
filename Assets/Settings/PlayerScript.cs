using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string playerName = "Ndu Champ"; // This box (variable) called playerName holds the text "Ndu Champ".
    public int playerAge = 70; // This box (variable) called playerAge holds the number "70".
    public float playerHealth = 100.5f; // This box (variable) called playerHealth holds the text "100.5f".
    public int playerDamage = 20; // This box (variable) called playerDamage holds the number "20".
    private bool isAlive = true; // This box (variable) called isAlive hold the true/false vaue.

    void Awake()
    {
        Debug.Log("Player name is -" + playerName);
        Debug.Log("Player health is -" + playerHealth);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
