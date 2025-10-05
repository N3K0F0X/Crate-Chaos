using UnityEngine;
using System.Collections;
using System.Linq;

public class Steam_Event : MonoBehaviour
{
    public bool IsSteamEvent;
    public GameObject Steam;
    private bool TurnEventOff;
    public float timer;


    // Update is called once per frame
    void Update()
    {

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            IsSteamEvent = true;
        }

        if (IsSteamEvent == true)
        {
            Steam.GetComponent<ParticleSystem>().enableEmission = true;
        }
        else
        {
            Steam.GetComponent<ParticleSystem>().enableEmission = false;
        }


        if (IsSteamEvent == true && TurnEventOff == true)
        {
           if (Input.GetKey(KeyCode.E))
            {
                IsSteamEvent = false;
                timer = 90;
           }
        }
    }

    
        

    private void OnTriggerEnter(Collider other)
    {
        if (IsSteamEvent == true)
        {
           TurnEventOff = true;
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        TurnEventOff = false;
    }
}

