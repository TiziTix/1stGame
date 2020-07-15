using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SameObject : MonoBehaviour
{
    public Transform objectB;
    public Transform otherPortal;
    public Transform portal;

    // Start is called before the first frame update
    void Start()
    {
        //Make objectB's position match objectB

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = objectB.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDifference * objectB.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);


    }
}
