using UnityEngine;
using System.Collections;

public class Steam_Slow : MonoBehaviour
{
    public Steam_Event SteamEvent;
    public Player_Movement Playermove;
    public GameObject Particals;

    // Update is called once per frame
    void Update()
    {
        if (SteamEvent.IsSteamEvent == true) 
        {
            Particals.GetComponent<ParticleSystem>().enableEmission = true;
        }
        if (SteamEvent.IsSteamEvent == false)
        {
            Particals.GetComponent<ParticleSystem>().enableEmission = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SteamEvent.IsSteamEvent == true)
        {
            Playermove.moveSpeed = Playermove.moveSpeed - 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Playermove.moveSpeed = 5;
    }

}
