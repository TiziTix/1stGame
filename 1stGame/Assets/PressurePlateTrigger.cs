using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateTrigger : MonoBehaviour
{
    
    [SerializeField] GameObject door;

    bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (!isOpen)
        {
            isOpen = true;
            door.transform.position = new Vector3(-1, 5, -9);
        }
    }
    void OnTriggerExit(Collider other)
    {
        door.transform.position = new Vector3(-1, 1, -9);
        isOpen = false;
    }

}
