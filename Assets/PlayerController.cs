using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(HorizontalMovement, 0, VerticalMovement);
        rb.AddForce(movement * Speed * Time.deltaTime);*/

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(h, 0, v);
        tempVect = tempVect.normalized * Speed * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);
    }
}
