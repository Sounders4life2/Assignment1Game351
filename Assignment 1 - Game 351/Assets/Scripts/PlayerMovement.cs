using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed = 5.0f;
    public float rotSpeed = 15.0f;
    private float horizInput;
    private float vertiInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update rotation and forward movement with keyboard inputs
        horizInput = Input.GetAxis("Horizontal");
        vertiInput = Input.GetAxis("Vertical");

        //move and rotate the player
        transform.Translate(Vector3.forward * Time.deltaTime * movSpeed * vertiInput);
        transform.Rotate(0, Time.deltaTime * rotSpeed * horizInput, 0);
    }
}
