using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRControllerGrabber : OVRGrabber
{
    /// <summary>
    /// By default OVRCameraRig is responsible for trigger OVRGrabber,
    /// however, current versions of both components don't seem to work together.
    /// This script forces the update to occur.
    /// </summary>

}
