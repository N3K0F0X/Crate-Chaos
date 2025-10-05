using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public float speed = 0.01f;
    public GameObject destination;
    public GameObject PriorDestination;
    public Elec_Event Electric;
    public GameObject Door;

    void Start()
    {
       PriorDestination.transform.localPosition = Door.transform.localPosition;
    }

    void Update()
    {
        if (Electric.IsElecEvent == true)
        {
            Door.transform.localPosition = destination.transform.localPosition; 
        }
        if (Electric.IsElecEvent == false)
        {
            Door.transform.localPosition = PriorDestination.transform.localPosition;
        }
    }
}