using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private GameObject focalPoint;
    private float speed = 5.0f;
    private float boostPow = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButton("Vertical") && Input.GetButton("Boost"))
        {
            playerRB.AddForce(focalPoint.transform.forward * verticalInput * speed * boostPow);
        } else if (Input.GetButton("Vertical"))
        {
            playerRB.AddForce(focalPoint.transform.forward * verticalInput * speed);
        }

    }
}
