using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TestCollisionWithColieders : MonoBehaviour
{
    public Transform spine;
    public Transform spine1; 
    public Transform spine2;
    public Transform leftHandIK;
    public Transform rightHandIK;
    public Transform leftHandAnchor;
    public Transform rightHandAnchor;

    private Vector3 lastposLeftHandIK = Vector3.zero;
    private Vector3 lastposRightHandIK = Vector3.zero;

    public double minDistanceToSpine = 0.16;
    public double minDistanceToSpine1 = 0.15;
    public double minDistanceToSpine2 = 0.16;
    public double maxDistanceToLHandAnchor = 0.01;
    public double maxDistanceToRHandAnchor = 0.01; 

    // Start is called before the first frame update
    void Start()
    {
        UpdateLastKnownPosition();
    }

    // Update is called once per frame
    void Update()
    {

        CheckDistanceToHandAnchor();

        CheckDistanceToSpineJoint(spine, minDistanceToSpine);
        CheckDistanceToSpineJoint(spine1, minDistanceToSpine1);
        CheckDistanceToSpineJoint(spine2, minDistanceToSpine2);

        UpdateLastKnownPosition();
    }

    private void CheckDistanceToSpineJoint(Transform spineJoint, double minDistance)
    {


        if (distance(spineJoint, leftHandAnchor) < minDistance)
        {
            leftHandAnchor.position = lastposLeftHandIK;
        }

        if (distance(spineJoint, rightHandAnchor) < minDistance)
        {
            rightHandAnchor.position = lastposRightHandIK;
        }
    }
    private void CheckDistanceToHandAnchor()
    {
        if (distance(leftHandAnchor, leftHandIK) > maxDistanceToLHandAnchor)
        {
            leftHandIK.position = leftHandAnchor.position;
        }
        if (distance(rightHandAnchor, rightHandIK) > maxDistanceToRHandAnchor)
        {
            rightHandIK.position = rightHandAnchor.position;
        }
    }
    private double distance (Transform a, Transform b)
    {
        var deltaX  = a.position.x - b.position.x;
        var deltaY = a.position.y - b.position.y;
        var deltaZ = a.position.z - b.position.z;

        return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ)); 
    }
    private void UpdateLastKnownPosition()
    {

        lastposLeftHandIK = leftHandAnchor.position;
        lastposRightHandIK = rightHandAnchor.position;
    }

}
