using UnityEngine;

namespace MyGame.Characters
{
    public class Villain : MonoBehaviour
    {
    public int damage = 25;

    public void PrintDamage()
    {
        Debug.Log("Villain damage is: " + damage);
    }
    }
}

