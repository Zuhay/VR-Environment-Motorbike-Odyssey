using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorUnlock : MonoBehaviour
{
    //sounds for items collected
    public AudioSource coinSound;
    public AudioSource doorUnlock;
    //text to display count completed
    public Text countText;
    //text to display task completed
    public Text winText;
    //count for the collectibles
    private int count;
    //item to be collected
    public GameObject collectItem;
    //door preventing the user from accessing upper floor
    public GameObject door;
    public GameObject TriggerObj;

    // Start is called before the first frame update
    void Start()
    {
        //Setting all the game objects to active initially 
        count = 0;
        winText.text = "";
        SetCountText();
        collectItem.gameObject.SetActive(true);
        door.gameObject.SetActive(true);
        TriggerObj.gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        //checking if player collided with the item and removing it from the scene
        if(other.gameObject.CompareTag("Collectibles"))
        {
            
            coinSound.Play();
            count = count + 1;
            other.gameObject.SetActive(false);
            SetCountText();
        }
    }

    void SetCountText()
    {
        //Counting the number of items collected and checking if task is completed
        countText.text = "Count: " + count.ToString();
        if(count >= 6)
        {
            //when task is complete unlocking door
            //setting game objects to false
            doorUnlock.Play();
            winText.text = "Upper Floor Unlocked!";  
            collectItem.gameObject.SetActive(false);
            countText.gameObject.SetActive(false);
            door.gameObject.SetActive(false);
            TriggerObj.gameObject.SetActive(false);
            
        }
    }
}
