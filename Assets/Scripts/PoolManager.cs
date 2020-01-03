using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{

    public static PoolManager current;  //can access other scripts 
    public string[] names;  //holds all names of objects in an array
    public GameObject[] pooledObjects; //array of prefabs
    public int[] poolAmounts; //amount of prefabs
    public Hashtable mainPool = new Hashtable(); //mix array types to search using a string value 
    public List<GameObject> tempList; //temporary list to store bullets 


    private void OnEnable()
    {
        current = this; //script can use it at runtime 
    }


    // Start is called before the first frame update
    void Start()
    {

        tempList = new List<GameObject>(); //creates the templist property 
        for(int i = 0; i < names.Length; i++) //loop starts with the total amount of names
        {
            List<GameObject> objList = new List<GameObject>(); //creates a new list at every iteration 
            for(int j = 0; j < poolAmounts[i]; j++) //loop to fill temporary array with gameobjects
            {
                GameObject obj = (GameObject)Instantiate(pooledObjects[i]); //creates the gameobject and adds it to the hierarchy
                obj.SetActive(false); //the gameobject will disappear 
                objList.Add(obj); //the new gameobject will be added 
            }

            mainPool.Add(names[i], objList); //creates our newly created list of gameobjects to the main pool
        }

        
    }


    public GameObject GetPooledObjects(string name)
    {
        if (mainPool.ContainsKey(name)) //checks if the mainpool contains a name 
        {
            tempList = mainPool[name] as List<GameObject>; //stores matching pooled objects in the templist array
            for(int i = 0; i < tempList.Count; i++) //loops through all the tempList's gameobjects
            {
                if (tempList[i] != null) //if the gameobject exists 
                    if (!tempList[i].activeInHierarchy) //if the gameobject exists in the hierarchy 
                        return tempList[i]; //return the GameObject 
            }
        }

        return null; //returns nothing 
    }


    public void ResetPool()
    {

        for(int i = 0; i < tempList.Count; i++) //loops through the names array to get each type of gameobject
        {
            if (tempList[i] != null) //if the templist is not equal to null
                if (tempList[i].activeInHierarchy) //if the object exists in the hierarchy 
                    tempList[i].SetActive(false); //disables the gameobject
        }


    }


    
}
