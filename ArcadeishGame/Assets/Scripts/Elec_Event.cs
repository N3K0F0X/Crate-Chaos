using UnityEngine;
using System.Collections;
using System.Linq;

public class Elec_Event : MonoBehaviour
{
    public float TimeEvent;
    public bool IsElecEvent;
    private bool TurnEventOff;


    public Light Light1;
    public Light Light2;
    public Light Light3;

    public Light WarningLight;

    public GameObject Doors;
    public GameObject Sparks;


    // Update is called once per frame
    void Update()
    {
        if (TimeEvent > 0)
        {
            TimeEvent -= Time.deltaTime;
        }
        else
        {
            IsElecEvent = true;
        }

        if (IsElecEvent == false)
        {
            Light1.GetComponent<Light>().enabled = true;
            Light2.GetComponent<Light>().enabled = true;
            Light3.GetComponent<Light>().enabled = true;
            Sparks.GetComponent<ParticleSystem>().enableEmission = false;
        }

        if (IsElecEvent == true)
        {
            Light1.GetComponent<Light>().enabled = false;
            Light2.GetComponent<Light>().enabled = false;
            Light3.GetComponent<Light>().enabled = false;
            WarningLight.GetComponent<Light>();
            Sparks.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(LightPause());
        }

        if (IsElecEvent == true && TurnEventOff == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                IsElecEvent = false;
                TimeEvent = 60;
            }
        }
    }

    IEnumerator LightPause()
    {
        WarningLight.GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(1);
        WarningLight.GetComponent<Light>().enabled = enabled;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsElecEvent == true)
        {
            TurnEventOff = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TurnEventOff = false;
    }
}
