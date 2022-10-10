using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //The destination target
    public Transform teleportTarget;
    //The player to be teleported
    public GameObject thePlayer;

    void OnTriggerEnter (Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
