using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bow bow = gameObject.AddComponent<Bow>();
        Sword sword = gameObject.AddComponent<Sword>();
        //Warrior warrior = gameObject.AddComponent<Warrior>();
        //warrior.name = "Magnus";
        //warrior.weapon = "The Throngler";

        //Debug.Log(warrior.name);
        //Debug.Log(warrior.weapon);
       List<Weapon> weapons = new List<Weapon> { sword, bow };
       foreach (Weapon weapon in weapons)
       {
        weapon.Attack();
       }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
