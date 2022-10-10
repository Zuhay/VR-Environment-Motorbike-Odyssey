using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoPlayPause : MonoBehaviour
{
    //Creating a button
    public GameObject button;

    private VideoPlayer video;


    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray casting to check if the player is looking at the video
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation *
        Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) &&
        (hit.collider.gameObject == gameObject))
        {
            //playing video when player is looking at it
            video.Play();
        }
        else
        {
            //stpoing video when player looks away
            video.Stop();
        }

    }
}
