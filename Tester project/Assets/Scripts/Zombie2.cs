using UnityEngine;

public class Zombie2 : MonoBehaviour, IDamageable
{
    int health = 200;
    
    int amount = 20;

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

}
