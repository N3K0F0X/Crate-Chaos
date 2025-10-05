using UnityEngine;

public class BoxFinder : MonoBehaviour
{
    private Rigidbody LastItemEntered;
    public GameObject Respawn;
    public int ScoreCounter;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Working as Intended");
        LastItemEntered = other.gameObject.GetComponent<Rigidbody>();

        if (LastItemEntered.name == "DepoBox(Clone)")
        {
            Debug.Log("This is a box");
            ScoreCounter++;
            Destroy(other.gameObject);
        }
        else
        {
            LastItemEntered.transform.localPosition = Respawn.transform.localPosition;
        }

    }

}
