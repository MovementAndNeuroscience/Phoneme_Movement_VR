using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFingerPicker : MonoBehaviour
{
    [Header("Replaces deprecated 'Finger Tip' script from Questionnaire submodule.")]
    [SerializeField] private Transform FingerTip;

    void Update() { transform.position = FingerTip.position; }
}
