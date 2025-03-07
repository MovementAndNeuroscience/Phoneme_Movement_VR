using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemTouchedEvent : MonoBehaviour
{
    [Tooltip("If not set, any collider will trigger.")]
    [SerializeField] private GameObject TouchedBy;
    [SerializeField] private UnityEvent OnItemTouched;
    [SerializeField] private bool Repeat = false;

    private bool Touched = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!Repeat && Touched) return;

        if (TouchedBy == null || other.gameObject.Equals(TouchedBy) || HasParent(other.gameObject,TouchedBy))
        {
            OnItemTouched.Invoke();
            enabled = false;
            Touched = true;
        }
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
}
