// As seen on
// https://github.com/MichaeliusDenModige/VR-Annotation-Scripts/blob/master/OVRCustomGrabbable.cs


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This component is intended for grabbable objects that are not supposed to be modified by physics,
/// meaning no gravity and no kinetics.
/// Unlike regular grabbables, an object with this component cannot be thrown, punched or dropped.
/// </summary>
public class OVRCustomGrabbable : OVRGrabbable
{
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        m_grabbedBy = null;
        m_grabbedCollider = null;
    }
}
