using UnityEngine;

public class Potion : MonoBehaviour
{
    public string potionName;
    public int potency;
    public int volume;

    public void Drink()
    {
        Debug.Log("You drank: " + potionName + potency + volume);
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
