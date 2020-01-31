using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpen : MonoBehaviour
{
        
    [SerializeField] Vector3 EndingPosition;
    [SerializeField] float openDelay = 5f;
    [SerializeField] float closeDelay = 10f;
    [SerializeField] float speed = 3f;
    bool doorsOpening = false;
    bool doorsClosing = false;
    private Vector3 StartingPosition;


    // Start is called before the first frame update
    void Start()
    {
        StartingPosition = transform.position;
        Invoke("OpenDoors", openDelay);
    }

    // Update is called once per frame
    void Update()
    {
         if(doorsOpening){
             float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, EndingPosition, step);
            if(EndingPosition == transform.position){
             doorsOpening = false;
            }
         }
         if(doorsClosing){
             float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, StartingPosition, step);
            if(StartingPosition == transform.position){
             doorsClosing = false;
            }
         }
    }

    void OpenDoors(){
        doorsOpening = true;
    }
    void CloseDoors(){
        doorsClosing = true;
    }
}
