using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string Name;
    public int Damage;

    public virtual void Attack()
    {
        Debug.Log("The weapon is attacking!");
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
