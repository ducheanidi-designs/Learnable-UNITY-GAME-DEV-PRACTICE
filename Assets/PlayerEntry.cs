using UnityEngine;

public class PlayerEntry : MonoBehaviour
{
 public string playerName = "Ndu" ; // This box (variable) holds "playerName" holds the text "Ndu".
    
    void Start()
    {
       playerName = "Ndu The gameLive"; 

       Debug.Log(playerName + " - Started the game");
    }      
}  
    


