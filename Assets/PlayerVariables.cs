using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    public string playerName = "Ndu"; // This box (variable) called playerName holds the text "Ndu".
    public int playerAge = 70; // This box (variable) called playerAge holds the number "70".
    public float playerSpeed = 6.5f; // This box (variable) called playerSpeed holds the text "6.5f".
    public bool isAlive = true; // This box (variable) called isAlive hold the true/false vaue.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(playerName + " - Player Name");
        Debug.Log(playerAge + " - Player Age");
        Debug.Log(playerSpeed + " - Game Speed");
        Debug.Log(isAlive + " - Game Health");
    }
}
