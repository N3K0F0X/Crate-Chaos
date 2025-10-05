using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;

    private float rotation;


    

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * Time.deltaTime * (moveSpeed * horizontalInput));
        transform.Translate(-Vector3.right * Time.deltaTime * (moveSpeed * verticalInput));

        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            moveSpeed = 7;
        }
        else
        {
            moveSpeed = 5;
        }

        

    }
}
