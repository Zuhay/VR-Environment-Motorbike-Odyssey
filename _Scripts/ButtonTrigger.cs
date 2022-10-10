using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;


    public GameObject Panel;



    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray cast created 
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation *
        Vector3.forward);
        RaycastHit hit;
        //Panel set active when ray cast hits it
        if (Physics.Raycast(ray, out hit) &&
        (hit.collider.gameObject == gameObject))
        {
            unityEvent.Invoke();
            Panel.SetActive(true);
           
        }
        else
        {
            Panel.SetActive(false);
            
        }
      
    }
}
