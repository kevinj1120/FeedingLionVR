using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourManager : MonoBehaviour
{
    public OVRGrabber leftHand;
    public OVRGrabber rightHand;
    public GameObject grabbedObject;

    List<FollowPlayer> tigers = new List<FollowPlayer>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void grabTest() //test
    {
        Debug.Log("Grabbing: " + grabbedObject);
    }
    private bool CheckForMeatGrab()
    {
        //this updates and looks for grabbing of the meat
        //returns true if grabbing meat.
        return false;
    }

    private void SetTigersToFollow()
    {
        //go through each tiger in list.
        //check if distance is close enough
        //if yes, set to follow.
    }
}
