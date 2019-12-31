using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    //public GameObject bulletPrefab;
    public Transform bulletSpwn; //position of bullet spawn
    public Transform bulletSpwn2; //position of bullet spawn 
    public float fireTime = 0.5f; //time in seconds between shots 

    private bool isFiring = false; //checks to see if it has fired or not 

    private void SetFiring()
    {
        isFiring = false; //isfiring is not enabled so no bullets can fire
    }

    private void Fire()
    {
        isFiring = true; //bullets are allowed to fire 
        


        GameObject bullet = PoolManager.current.GetPooledObjects("Bullet");
        if(bullet != null)
        {
            bullet.transform.position = bulletSpwn.position; //set position
            bullet.transform.rotation = bulletSpwn.rotation; //set rotation
            bullet.SetActive(true); //enables bullet 

        }

        GameObject bullet2 = PoolManager.current.GetPooledObjects("Bullet2");
        if(bullet2 != null)
        {
            bullet2.transform.position = bulletSpwn2.position;
            bullet2.transform.rotation = bulletSpwn2.rotation;
            bullet2.SetActive(true);
        }




        if(GetComponent<AudioSource>() != null) //checks for an audio component
        {
            GetComponent<AudioSource>().Play(); //plays the audio from the component 
        }

        Invoke("SetFiring", fireTime); //sets an invoke timer to reset the isfiring property
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) //if the left mouse button is held down
        {
            if (!isFiring) //if isfiring is not firing 
            {
                Fire(); //run this method 
            }
        }
    }




}
