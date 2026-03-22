 using UnityEngine;

public class PracticeScript : MonoBehaviour
{
    private string PlayerName = "Ndu";

    void Awake()
    {
        Function();
        
        Debug.Log("Awake was called");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start was called");
    }

    void Function()
    {
        Debug.Log(PlayerName);
    }
}
