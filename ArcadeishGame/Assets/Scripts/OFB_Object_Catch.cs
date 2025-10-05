using UnityEngine;

public class OFB_Object_Catch : MonoBehaviour
{
    public GameObject Respawn;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            other.gameObject.transform.position = Respawn.transform.position;
        }
    }
}
