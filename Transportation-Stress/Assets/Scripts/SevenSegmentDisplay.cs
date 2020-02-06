using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SevenSegmentDisplay : MonoBehaviour
{   
    MeshRenderer mesh;
    public bool[] ProgrammingTable = new bool[16]; //Basement is Position 15
    public Color onColor;
    public Color offColor;
    private int floorLevel = 15; //Starts on the 14th floor and goes to zero (15 floors) Basement is position 15 in array

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
        mesh.material.color = offColor;
        Invoke("Count", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Count(){
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
        floorLevel--;
        if(ProgrammingTable[floorLevel]){
            mesh.material.color = onColor;
        }
        else{
            mesh.material.color = offColor;
        }

        if(floorLevel > 0){
            Invoke("Count", 2f);
        }
        else{
            Invoke("Basement", 2f);
        }
    }

    public void Basement(){
         MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
            
        if(ProgrammingTable[15]){
            mesh.material.color = onColor;
        }
        else{
            mesh.material.color = offColor;
        }
    }
}
