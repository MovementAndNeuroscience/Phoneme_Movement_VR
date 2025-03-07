using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDebuggingTools : MonoBehaviour
{
    [SerializeField] private Behaviour[] behaviours;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var b in behaviours)
            b.enabled = false;
        if (!Application.isEditor)
            enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isEditor)
            if (OVRInput.GetDown(OVRInput.RawButton.B))
                foreach (var b in behaviours)
                    b.enabled = !b.enabled;
    }
}
