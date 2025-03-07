using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjuster : MonoBehaviour
{
    [SerializeField] private float HeightSensitivity = 0.05f;

    [Range(0.25f, 0.95f)]
    [SerializeField] private float ThumbstickYThreshold = 0.8f;

    private float yAxisOnPreviousFrame;

    private void Start() { if (Application.isEditor) enabled = false; }

    // Update is called once per frame
    void Update()
    {
        if (yAxisOnPreviousFrame < ThumbstickYThreshold && ThumbstickYThreshold < GetY())
            transform.localPosition += Vector3.up * HeightSensitivity;
        if (yAxisOnPreviousFrame > -ThumbstickYThreshold && -ThumbstickYThreshold > GetY())
            transform.localPosition += Vector3.down * HeightSensitivity;

        yAxisOnPreviousFrame = GetY();

        float GetY() { return OVRInput.Get(OVRInput.RawAxis2D.RThumbstick).y; }
    }


}
