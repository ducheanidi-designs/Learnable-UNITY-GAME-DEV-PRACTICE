using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string playerName = "Ndu D.Champ"; // This box (variable) called playerName holds the text "Ndu D.Champ".
    public int playerAge = 70; // This box (variable) called playerAge holds the number "70".
    private int playerHealth = 100; // This box (variable) called playerHealth holds the text "100".
    private int playerDamage = 20; // This box (variable) called playerDamage holds the number "20".
    private bool isAlive = true; // This box (variable) called isAlive hold the true/false vaue.

    void Awake()
    {
        Debug.Log("Player name is -" + playerName);
        Debug.Log("Player age is -" + playerAge);
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
