using UnityEngine;

public class Orc2 : MonoBehaviour, IDamageable
{
    int health = 50;


    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Orc took " + amount + "damage");
    }

}
