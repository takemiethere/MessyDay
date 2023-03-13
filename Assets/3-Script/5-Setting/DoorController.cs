using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float doorOpenAngle = -90.0f;
    public float doorCloseAngle = 0.0f;
    public float smooth = 2.0f;
    public bool open = false;

    private Quaternion openRotation;
    private Quaternion closeRotation;

    void Start()
    {
        // Set the door to its initial closed position
        closeRotation = transform.localRotation;
        openRotation = Quaternion.Euler(0, doorOpenAngle, 0) * closeRotation;
    }

    void OnTriggerEnter(Collider other)
    {
        // If the player enters the trigger area, open the door
        if (other.gameObject.tag == "Player")
        {
            open = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // If the player exits the trigger area, close the door
        if (other.gameObject.tag == "Player")
        {
            open = false;
        }
    }

    void Update()
    {
        // Smoothly rotate the door to its open or closed position
        Quaternion targetRotation = open ? openRotation : closeRotation;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
