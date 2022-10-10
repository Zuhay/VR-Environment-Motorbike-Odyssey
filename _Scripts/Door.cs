using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject movingDoor;

    //Checking to see if player is present
    bool playerIsHere;
    bool opening;

    //Opening distance of the doors 
    private float maximumOpening = 13f;
    private float maximumClosing = 6.7f;

    //Speed of the door 
    private float doorSpeed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        opening = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if(movingDoor.transform.position.y < maximumOpening)
            {
                movingDoor.transform.Translate(0f, doorSpeed * Time.deltaTime, 0f);
            }
        }
        else if (!playerIsHere) 
        { 
            if(movingDoor.transform.position.y > maximumClosing)
            {
                movingDoor.transform.Translate(0f, -doorSpeed * Time.deltaTime, 0f);
            }
        }
    }

    //Opens door upon trigger
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }

    //Closes door
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}
