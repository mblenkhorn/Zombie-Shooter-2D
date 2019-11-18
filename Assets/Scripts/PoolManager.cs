using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{

    public static PoolManager current;  //can access other scripts 
    public string[] names;  //holds all names of objects in an array
    public GameObject[] pooledObjects; //array of prefabs
    public int[] poolAmounts; //amount of prefabs
    public Hashtable mainPool = new Hashtable();
    public List<GameObject> tempList;


    private void OnEnable()
    {
        current = this;
    }


    // Start is called before the first frame update
    void Start()
    {

        tempList = new List<GameObject>();
        for(int i = 0; i < names.Length; i++)
        {
            List<GameObject> objList = new List<GameObject>();
            for(int j = 0; j < poolAmounts.Length; j++)
            {
                GameObject obj = (GameObject)Instantiate(pooledObjects[i]);
                obj.SetActive(false);
                objList.Add(obj);
            }

            mainPool.Add(names[i], objList);
        }

        
    }


    public GameObject GetPooledObjects(string name)
    {
        if (mainPool.ContainsKey(name))
        {
            tempList = mainPool[name] as List<GameObject>;
            for(int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i] != null)
                    if (!tempList[i].activeInHierarchy)
                        return tempList[i];
            }
        }

        return null;
    }


    public void ResetPool()
    {

        for(int i = 0; i < tempList.Count; i++)
        {
            if (tempList[i] != null)
                if (tempList[i].activeInHierarchy)
                    tempList[i].SetActive(false);
        }


    }


    
}
