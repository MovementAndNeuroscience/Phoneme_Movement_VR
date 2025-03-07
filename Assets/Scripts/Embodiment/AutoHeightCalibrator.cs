using System.Collections;
using UnityEngine;

/// <summary>
/// This code fixes the height (eye-level) of the participants to the absoluteHeight parameter.
/// It should be placed on the TrackingSpace gameObject in the CameraRig. 
/// </summary>

public class AutoHeightCalibrator : MonoBehaviour
{

    [SerializeField] private float absoluteHeight = 1.7f;
    [SerializeField] private Transform CenterEyeAnchor;

    private IEnumerator Start()
    {
        if (CenterEyeAnchor != null)
        {
            while (CenterEyeAnchor.localPosition == Vector3.zero)
                yield return new WaitForSeconds(0.1f);

            transform.localPosition += new Vector3(0, absoluteHeight - CenterEyeAnchor.position.y, 0);
        }
    }

}
