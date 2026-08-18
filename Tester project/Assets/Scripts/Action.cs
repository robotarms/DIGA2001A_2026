using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Warrior warrior = gameObject.AddComponent<Warrior>();
        warrior.name = "Magnus";
        warrior.weapon = "The Throngler";

        Debug.Log(warrior.name);
        Debug.Log(warrior.weapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
