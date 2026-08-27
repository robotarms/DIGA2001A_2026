using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string _species;
    private int _numArms;
    private int _numLegs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animal()
    {
        Debug.Log("Animal Created");
    }

    public Animal(string animalSpecies, int arms, int legs)
    {
        _species = animalSpecies;
        _numArms = arms;
        _numLegs = legs;
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
