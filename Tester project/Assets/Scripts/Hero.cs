using UnityEngine;

namespace MyGame.Characters
{
public class Hero : MonoBehaviour
{
    public int health = 100;

    public void PrintHealth()
    {
        Debug.Log("Hero health is: " + health);
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
}
