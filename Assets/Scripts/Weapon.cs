using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    //public GameObject bulletPrefab;
    public Transform bulletSpwn;
    public Transform bulletSpwn2;
    public float fireTime = 0.5f;

    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }

    private void Fire()
    {
        isFiring = true;
        //Instantiate(bulletPrefab, bulletSpwn.position, bulletSpwn.rotation);
        //Instantiate(bulletPrefab, bulletSpwn2.position, bulletSpwn2.rotation);


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




        if(GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", fireTime);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }




}
