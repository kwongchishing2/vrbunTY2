using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixPlayerZposition : MonoBehaviour
{
    public GameObject Player;
    public AudioSource hurt;
    public bool started = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "p"&&started==true)
        {
            hurt.Play();
            Vector3 newPosition = Player.transform.position;
            newPosition.x = -30.780641555786134f;
            newPosition.y = 25.6630916595459f;
           newPosition.z = -19.730478286743165f; 
            Player.transform.position = newPosition;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "p" && started == true)
        {
            started = false;
        }
    }
}
