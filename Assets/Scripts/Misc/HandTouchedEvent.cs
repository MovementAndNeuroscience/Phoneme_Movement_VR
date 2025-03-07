using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandTouchedEvent : MonoBehaviour
{
    [Tooltip("If not set, any collider will trigger.")]
    [SerializeField] private GameObject LeftHand, RightHand;
    [SerializeField] private UnityEvent OnItemTouched;
    [SerializeField] private bool Repeat = false;

    private bool Touched = false;

    private void OnTriggerEnter(Collider other)
    {
        if (LeftHand == null && RightHand == null) SetReferences();

        if (!Repeat && Touched) return;

        if (ObjectTouched(LeftHand) || ObjectTouched(RightHand))
        {
            OnItemTouched.Invoke();
            enabled = false;
            Touched = true;
        }

        bool ObjectTouched(GameObject gameObject) { return (gameObject == null || other.gameObject.Equals(gameObject) || HasParent(other.gameObject, gameObject)); }
    }

    public static bool HasParent(GameObject gameObject, GameObject target)
    {
        Transform t = gameObject.transform;
        while (t.parent != null)
            if (t.gameObject.Equals(target))
                return true;
            else
                t = t.parent;
        return false;
    }

    private void SetReferences()
    {
        RightHand = GameObject.FindGameObjectWithTag("RightHand").transform.parent.gameObject;
        LeftHand = GameObject.FindGameObjectWithTag("LeftHand").transform.parent.gameObject;
    }
}
