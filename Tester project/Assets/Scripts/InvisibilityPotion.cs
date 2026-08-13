using UnityEngine;

public class InvisibilityPotion : Potion
{
    public void BecomeInvisible()
    {
        Debug.Log("You became invisible!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BecomeInvisible();
        Drink();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
