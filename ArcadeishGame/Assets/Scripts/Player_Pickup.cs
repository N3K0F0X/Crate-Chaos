using UnityEngine;

public class Player_Pickup : MonoBehaviour
{
    [HideInInspector]
    public bool HasObject = false;

    [HideInInspector]
    public Rigidbody ClosestItem;

    private Rigidbody Pickupable;
    public GameObject ItemPosition;
    public Vector3 WhereItGoes;
    private Vector3 WhereItWas;

    
    //a raycast would have made this 1000 times easier




    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (HasObject == false)
            {
                Pickupable = ClosestItem;
                WhereItGoes = ItemPosition.transform.position;
                Pickupable.transform.position = WhereItGoes;
                Pickupable.isKinematic = true;

                HasObject = true;
            }
            else
            {
                Pickupable.isKinematic = false;
                Pickupable.transform.position = WhereItWas;
                Pickupable = null;
                HasObject = false;
            }
        }

        if (HasObject == true)
        {
            WhereItGoes = ItemPosition.transform.position;
            WhereItWas = WhereItGoes;
            Pickupable.transform.position = WhereItGoes;
            Pickupable.isKinematic = true;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (HasObject ==false)
        {
            if (other.CompareTag("Object"))
            {
                ClosestItem = other.gameObject.GetComponent<Rigidbody>();

            }

        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Object"))
        {
            ClosestItem = null;
        }
        
    }


}
