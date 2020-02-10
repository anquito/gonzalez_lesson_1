using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float verticalSpeed = 20;
    public float horizontalSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);

        float horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
