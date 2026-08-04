using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Animal("Dog", 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
