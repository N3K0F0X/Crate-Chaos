using UnityEngine;

public class TriangleFinder : MonoBehaviour
{
    private Rigidbody LastItemEntered;
    public GameObject Respawn;
    public int ScoreCounter;
   

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Working as Intended");
        LastItemEntered = other.gameObject.GetComponent<Rigidbody>();

        
        if (LastItemEntered.name == "DepoTriangle(Clone)") 
        {
            Debug.Log("This is a Triangle");
            ScoreCounter++;
            Destroy(LastItemEntered);
        }
        else
        {
            LastItemEntered.transform.localPosition = Respawn.transform.localPosition;
        }

    }

}
