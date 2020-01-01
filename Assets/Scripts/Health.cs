using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Life;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("RestoreHealth", Life, SendMessageOptions.DontRequireReceiver);
        if (gameObject.CompareTag("Health"))
        {
            Destroy(gameObject);
        }
    }

}
