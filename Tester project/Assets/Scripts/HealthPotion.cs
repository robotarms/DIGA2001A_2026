using UnityEngine;

public class HealthPotion : Potion
{
    public void RestoreHealth()
    {
        Debug.Log("Health is restored!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RestoreHealth();
        Drink();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
