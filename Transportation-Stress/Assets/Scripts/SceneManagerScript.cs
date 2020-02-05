using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject josh;
    public Animator joshAnimator;
    [SerializeField] private float joshWalkDelay = 2f;
    [SerializeField] private float joshDestroyDelay = 10f;
    [SerializeField] private GameObject louise;
    public Animator louiseAnimator;
    [SerializeField] private float louiseWalkDelay = 3f;
    [SerializeField] private float louiseDestroyDelay = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("JoshLeaveElevator", joshWalkDelay);
        Invoke("LouiseLeaveElevator", louiseWalkDelay);
        Destroy(josh, joshDestroyDelay);
        Destroy(louise, louiseDestroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoshLeaveElevator()
    {
       joshAnimator.SetTrigger("LeaveElevator");
    }

    public void LouiseLeaveElevator()
    {
        louiseAnimator.SetTrigger("LeaveElevator");
    }
}