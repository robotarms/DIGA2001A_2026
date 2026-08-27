using UnityEngine;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour
{
    public GameObject prefab; //object to pool
    public int poolSize = 10; //number of objects to preinstantiate

    private List<GameObject> pool = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //create pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        //try to find inactive object
        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy) //if not active in hierarchy, then they are available in pool
            {
                pool[i].SetActive(true); //set active when called
                return pool[i]; //return object to calling class
            }

        }
        //If we got here then all objects are active; we must reset pool
        for (int i = 0; i < pool.Count; i++)
        {
            pool[i].SetActive(false);
        }

//Hand out first object after reset
        var obj = pool[0];
        obj.SetActive(true);
        return obj;
    }
}
