using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpen : MonoBehaviour
{
        
    [SerializeField] Vector3 EndingPosition;
    [SerializeField] float delay = 5f;
    [SerializeField] float speed = 3f;
    bool doorsOpening = false;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("OpenDoors", delay);
    }

    // Update is called once per frame
    void Update()
    {
         if(doorsOpening){
             float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, EndingPosition, step);
         }
         if(EndingPosition == transform.position){
             doorsOpening = false;
         }
       
    }

    void OpenDoors(){
        doorsOpening = true;
    }
}
