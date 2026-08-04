using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private string name;
    private int arms;
    private int legs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public Zombie(string zombieName, int zombieArms, int zombieLegs)
    {
        name = zombieName;
        arms = zombieArms;
        legs = zombieLegs;
    }


    public void setLegs(int newLegs)
    {
        legs = newLegs;
    }

    public int getArms()
    {
        return arms;
    }

    public int getLegs()
    {
        return legs;
    }

}
