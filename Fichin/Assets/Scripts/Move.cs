using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator anim;
    public Transform playerPos;
    public Transform cam;
    public bool isJumping;
    public float startY;
    Vector3 playerPosRight;
    public float fwdForce = 239;
    public float upForce = 250;
    public float rotateSpeed = 7;

    void Start()
    {
        cam = Camera.main.transform;
        playerPos = gameObject.transform;
        playerPosRight = playerPos.TransformDirection(Vector3.forward);
        isJumping = false;
        startY = transform.position.y;
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        if (transform.position.y > 2.55f)
        {
            isJumping = true;
        }
        else if (transform.position.y < 2.55f)
        {
            isJumping = false;
        }
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;

            // Apply a force relative to the player's x-axis
            GetComponent<Rigidbody>().AddForce((playerPosRight * fwdForce) + (Vector3.up * upForce));
        }
    }

}