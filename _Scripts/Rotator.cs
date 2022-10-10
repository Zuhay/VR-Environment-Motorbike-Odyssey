using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //Rotation axis
    [SerializeField] private Vector3 _rotation;
    //Rotation speed 
    [SerializeField] private float _speed;



    void Update()
    {
        //creating ray cast
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
        //checking if player is looking at the object
        if (Physics.Raycast(ray, out hit) &&
        (hit.collider.gameObject == gameObject))
        {
            //rotating the object
            transform.Rotate(_rotation * _speed * Time.deltaTime);
        }
       
        
    }
}
