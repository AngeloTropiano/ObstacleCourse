using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 20;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            float xValue =Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float yValue = 0;
            float zValue = Input.GetAxis("Vertical")  * Time.deltaTime * moveSpeed;

            Vector3 movement = new Vector3(xValue,yValue,zValue);
            rb.MovePosition(rb.position + movement *moveSpeed * Time.deltaTime);
    }
}
