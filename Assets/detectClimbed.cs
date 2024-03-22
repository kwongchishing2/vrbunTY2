using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectClimbed : MonoBehaviour
{
    public fixPlayerZposition fixPlayerZposition;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "p")
        {
            fixPlayerZposition.started = true;
        }
    }
}
