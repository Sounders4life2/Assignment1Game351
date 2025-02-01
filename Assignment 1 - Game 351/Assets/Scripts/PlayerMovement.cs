using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float rotateInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update rotation and forward movement with keyboard inputs
        rotateInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move and rotate the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.right * Time.deltaTime * speed * forwardInput);
    }
}
