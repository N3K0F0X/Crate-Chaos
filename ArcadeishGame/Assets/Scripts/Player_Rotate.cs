using UnityEngine;

public class Player_Rotate : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.localRotation = Quaternion.Euler(0,180,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localRotation = Quaternion.Euler(0,0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0,90, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0,-90, 0);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)) 
        {
            transform.localRotation = Quaternion.Euler(0, 135, 0);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, -135, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, 60, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, -60, 0);
        }
    }
}
