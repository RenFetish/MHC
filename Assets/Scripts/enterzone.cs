using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterzone : MonoBehaviour
{
    public GameObject player;
    public static bool coll;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
            coll = true;
    }
    private void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject == player)
            coll = false;
    }
}
