using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Node = UnityEngine.XR.XRNode;
using System;

public class LimitReach_CameraRig : OVRCameraRig
{
    [Serializable]
    private class Settings
    {
        public float DistanceThreshold = 0.1f;
        public float AngleThreshold = 0.1f;
    }

    [Serializable]
    private class References
    {
        public Transform VRIKLeftHand, VRIKRightHand;
        public Transform LUpperArm, RForearm;
        public Transform VRIKLeftTarget, VRIKRightTarget;
    }

    [SerializeField] private Settings settings;
    [SerializeField] private References references;

    private float maxDistance;


    internal void GetAvatarHandReferences()
    {
        references.VRIKLeftHand = GameObject.FindGameObjectWithTag("AvatarLeftHand").transform;
        references.VRIKRightHand = GameObject.FindGameObjectWithTag("AvatarRightHand").transform;

        references.LUpperArm = references.VRIKLeftHand.parent.parent;
        references.RForearm = references.VRIKRightHand.parent.parent;

        references.VRIKLeftTarget = leftHandAnchor.GetChild(leftHandAnchor.transform.childCount - 1);
        references.VRIKRightTarget = rightHandAnchor.GetChild(rightHandAnchor.transform.childCount - 1);
    }


    protected override void UpdateAnchors(bool updateEyeAnchors, bool updateHandAnchors)
    {
        if (references.VRIKLeftHand == null)
        {
            base.UpdateAnchors(updateEyeAnchors, updateHandAnchors);
            return;
        }

        #region Irrelevant

        if (!OVRManager.OVRManagerinitialized)
            return;

        EnsureGameObjectIntegrity();

        if (!Application.isPlaying)
            return;

        if (_skipUpdate)
        {
            centerEyeAnchor.FromOVRPose(OVRPose.identity, true);
            leftEyeAnchor.FromOVRPose(OVRPose.identity, true);
            rightEyeAnchor.FromOVRPose(OVRPose.identity, true);

            return;
        }

        bool monoscopic = OVRManager.instance.monoscopic;
        bool hmdPresent = OVRNodeStateProperties.IsHmdPresent();


        OVRPose tracker = OVRManager.tracker.GetPose();

        trackerAnchor.localRotation = tracker.orientation;

        Quaternion emulatedRotation = Quaternion.Euler(-OVRManager.instance.headPoseRelativeOffsetRotation.x, -OVRManager.instance.headPoseRelativeOffsetRotation.y, OVRManager.instance.headPoseRelativeOffsetRotation.z);

        //Note: in the below code, when using UnityEngine's API, we only update anchor transforms if we have a new, fresh value this frame.
        //If we don't, it could mean that tracking is lost, etc. so the pose should not change in the virtual world.
        //This can be thought of as similar to calling InputTracking GetLocalPosition and Rotation, but only for doing so when the pose is valid.
        //If false is returned for any of these calls, then a new pose is not valid and thus should not be updated.
        if (updateEyeAnchors)
        {
            if (hmdPresent)
            {
                Vector3 centerEyePosition = Vector3.zero;
                Quaternion centerEyeRotation = Quaternion.identity;

                if (OVRNodeStateProperties.GetNodeStatePropertyVector3(Node.CenterEye, NodeStatePropertyType.Position, OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render, out centerEyePosition))
                    centerEyeAnchor.localPosition = centerEyePosition;
                if (OVRNodeStateProperties.GetNodeStatePropertyQuaternion(Node.CenterEye, NodeStatePropertyType.Orientation, OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render, out centerEyeRotation))
                    centerEyeAnchor.localRotation = centerEyeRotation;
            }
            else
            {
                centerEyeAnchor.localRotation = emulatedRotation;
                centerEyeAnchor.localPosition = OVRManager.instance.headPoseRelativeOffsetTranslation;
            }

            if (!hmdPresent || monoscopic)
            {
                leftEyeAnchor.localPosition = centerEyeAnchor.localPosition;
                rightEyeAnchor.localPosition = centerEyeAnchor.localPosition;
                leftEyeAnchor.localRotation = centerEyeAnchor.localRotation;
                rightEyeAnchor.localRotation = centerEyeAnchor.localRotation;
            }
            else
            {
                Vector3 leftEyePosition = Vector3.zero;
                Vector3 rightEyePosition = Vector3.zero;
                Quaternion leftEyeRotation = Quaternion.identity;
                Quaternion rightEyeRotation = Quaternion.identity;

                if (OVRNodeStateProperties.GetNodeStatePropertyVector3(Node.LeftEye, NodeStatePropertyType.Position, OVRPlugin.Node.EyeLeft, OVRPlugin.Step.Render, out leftEyePosition))
                    leftEyeAnchor.localPosition = leftEyePosition;
                if (OVRNodeStateProperties.GetNodeStatePropertyVector3(Node.RightEye, NodeStatePropertyType.Position, OVRPlugin.Node.EyeRight, OVRPlugin.Step.Render, out rightEyePosition))
                    rightEyeAnchor.localPosition = rightEyePosition;
                if (OVRNodeStateProperties.GetNodeStatePropertyQuaternion(Node.LeftEye, NodeStatePropertyType.Orientation, OVRPlugin.Node.EyeLeft, OVRPlugin.Step.Render, out leftEyeRotation))
                    leftEyeAnchor.localRotation = leftEyeRotation;
                if (OVRNodeStateProperties.GetNodeStatePropertyQuaternion(Node.RightEye, NodeStatePropertyType.Orientation, OVRPlugin.Node.EyeRight, OVRPlugin.Step.Render, out rightEyeRotation))
                    rightEyeAnchor.localRotation = rightEyeRotation;
            }
        }

        // Don't do nothing when hand tracking is on.
        if (updateHandAnchors && !OVRPlugin.GetHandTrackingEnabled())
        //if (updateHandAnchors)
        {
            //Need this for controller offset because if we're on OpenVR, we want to set the local poses as specified by Unity, but if we're not, OVRInput local position is the right anchor
            if (OVRManager.loadedXRDevice == OVRManager.XRDevice.OpenVR)
            {
                if (OVRNodeStateProperties.GetNodeStatePropertyVector3(Node.LeftHand, NodeStatePropertyType.Position, OVRPlugin.Node.HandLeft, OVRPlugin.Step.Render, out Vector3 leftPos))
                    leftHandAnchor.localPosition = leftPos;
                if (OVRNodeStateProperties.GetNodeStatePropertyVector3(Node.RightHand, NodeStatePropertyType.Position, OVRPlugin.Node.HandRight, OVRPlugin.Step.Render, out Vector3 rightPos))
                    rightHandAnchor.localPosition = rightPos;
                if (OVRNodeStateProperties.GetNodeStatePropertyQuaternion(Node.LeftHand, NodeStatePropertyType.Orientation, OVRPlugin.Node.HandLeft, OVRPlugin.Step.Render, out Quaternion leftQuat))
                    leftHandAnchor.localRotation = leftQuat;
                if (OVRNodeStateProperties.GetNodeStatePropertyQuaternion(Node.RightHand, NodeStatePropertyType.Orientation, OVRPlugin.Node.HandRight, OVRPlugin.Step.Render, out Quaternion rightQuat))
                    rightHandAnchor.localRotation = rightQuat;
            }
            else
            #endregion
            {
                leftHandAnchor.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
                rightHandAnchor.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

                leftHandAnchor.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
                rightHandAnchor.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);


                const float increment = 1.005f;
                ScaleArm(references.VRIKLeftHand, references.VRIKLeftTarget);
                ScaleArm(references.VRIKRightHand, references.VRIKRightTarget);

                // Had to experiment until I had 178 lines of deprecated code before anything damn worked.
                void ScaleArm(Transform VRIKHand, Transform VRIKTarget)
                {
                    Transform foreArm = VRIKHand.parent;
                    Transform upperArm = foreArm.parent;

                    if (new Vector2(
                        GetAbsoluteAngle(foreArm.localEulerAngles.x),
                        GetAbsoluteAngle(foreArm.localEulerAngles.y)).magnitude < settings.AngleThreshold)
                    {
                        if (Vector3.Distance(VRIKHand.position, VRIKTarget.position) > settings.DistanceThreshold)
                        {
                            float prevDistance = Vector3.Distance(VRIKTarget.position, VRIKHand.position);
                            upperArm.localScale = foreArm.localScale = new Vector3(foreArm.localScale.x * increment, 1, 1);
                            float distance = Vector3.Distance(VRIKTarget.position, VRIKHand.position);
                            if (distance > prevDistance)
                                upperArm.localScale = foreArm.localScale = new Vector3(foreArm.localScale.x / increment, 1, 1);
                        }
                    }
                    else if (upperArm.localScale.x > 1f)
                        upperArm.localScale = foreArm.localScale = new Vector3(foreArm.localScale.x / increment, 1, 1);


                    float GetAbsoluteAngle(float input) { return (input > 350) ? Mathf.Abs(input - 360) : input; }
                }





                #region Garbage
                void Freeze()
                {
                    float distance;
                    var given = leftHandAnchor.position;
                    if (references.VRIKLeftHand.parent.localEulerAngles.magnitude < settings.AngleThreshold)
                        maxDistance = Vector3.Distance(references.LUpperArm.position, references.VRIKLeftHand.position);
                    else
                        maxDistance = 99f;
                    if (Vector3.Distance(references.LUpperArm.position, leftHandAnchor.position) > maxDistance)
                    {
                        leftHandAnchor.position = references.VRIKLeftHand.position;
                        var displacement = leftHandAnchor.position - references.VRIKLeftTarget.position;
                        leftHandAnchor.position += displacement;
                    }
                    if (maxDistance == 99f)
                        if ((distance = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftTarget.position)) > settings.DistanceThreshold)
                        {
                            leftHandAnchor.position = references.VRIKLeftHand.position;
                            var displacement = leftHandAnchor.position - references.VRIKLeftTarget.position;
                            leftHandAnchor.position += displacement;
                        }
                        else
                        {
                            if (Vector3.Distance(references.LUpperArm.position, references.VRIKLeftHand.position) < maxDistance)
                                leftHandAnchor.position = given;
                        }
                    if (false)
                        if (Vector3.Distance(references.LUpperArm.position, given) < Vector3.Distance(references.LUpperArm.position, leftHandAnchor.position))
                            leftHandAnchor.position = given;
                }
                //upperArm.localScale = foreArm.localScale *= increment;
                //upperArm.localScale = foreArm.localScale /= increment;
                //prevDistance = Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position);
                //distance = Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position);
                //if (distance > prevDistance)
                //    upperArm.localScale = foreArm.localScale = new Vector3(foreArm.localScale.x * increment, 1, 1);
                //Vector3 LPrevious = leftHandAnchor.position;
                //Vector3 RPrevious = rightHandAnchor.position;
                // If you rotate the controller in the complete opposite direction (finger towards the shoulder)
                // and then place the controller in the distance,
                // the wrist reaches farther. Which means that the World-position we're calculating has been flawed.
                // We need to go up the parent hierarchy and find the wrist.
                //if (foreArm.localEulerAngles.magnitude < settings.AngleThreshold)
                //    maxDistance = Vector3.Distance(references.LUpperArm.position, references.VRIKLeftHand.position);
                //else
                //    maxDistance = 99f;
                //float x = upperArm.localScale.x;
                //upperArm.localScale = foreArm.localScale = new Vector3(x, 1, 1);
                //do
                //{
                //    prevDistance = Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position);
                //    foreArm.localScale = upperArm.localScale = Vector3.one * (multiplier *= increment);
                //    distance = Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position);
                //}
                //while (distance < prevDistance);
                //distance = Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position);
                //{
                //    //var before = references.VRIKLeftHand.position;
                //    Vector3 given = leftHandAnchor.position;
                //    distance = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftTarget.position);
                //    if (allowFuncCall)
                //    {
                //        if (references.LForearm.localEulerAngles.magnitude < settings.AngleThreshold)
                //            if ((distance = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftTarget.position)) > settings.DistanceThreshold)
                //                func();
                //        //if (enableDatShite)
                //        if ((distance = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftTarget.position)) > settings.DistanceThreshold)
                //            func();
                //        void func()
                //        {
                //            leftHandAnchor.position = references.VRIKLeftHand.position;
                //            var displacement = leftHandAnchor.position - references.VRIKLeftTarget.position;
                //            leftHandAnchor.position += displacement;
                //            allowFuncCall = true;
                //        }
                //    }
                //    else
                //        leftHandAnchor.position = given;
                //    if (Vector3.Distance(references.LForearm.position, given) < Vector3.Distance(references.LForearm.position, leftHandAnchor.position))
                //    {
                //        leftHandAnchor.position = given;
                //        allowFuncCall = false;
                //    }
                //}
                //settings.DistanceThreshold = distance;
                // First attemp
                //{
                //    //if (references.LForearm.localEulerAngles.magnitude < settings.AngleThreshold)
                //    {
                //        int i = 0;
                //        while (Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position) >= settings.DistanceThreshold)
                //            if (++i > 9999) throw new Exception("What the fuck");
                //            else leftHandAnchor.position = Vector3.MoveTowards(leftHandAnchor.position, references.VRIKLeftHand.position, 0.01f);
                //    }
                //}
                //// First attemp
                //{
                //    if (references.LForearm.localEulerAngles.magnitude < settings.AngleThreshold)
                //    {
                //        int i = 0;
                //        while (Vector3.Distance(references.VRIKLeftTarget.position, references.VRIKLeftHand.position) > settings.DistanceThreshold)
                //            if (++i > 9999) throw new Exception("What the fuck");
                //            else leftHandAnchor.position = Vector3.MoveTowards(leftHandAnchor.position, references.VRIKLeftHand.position, 0.01f);
                //    }
                //}
                //something();
                //void something()
                //{
                //    distance = Vector3.Distance(leftHandAnchor.position, references.VRIKLeftHand.position);
                //    if (distance > settings.DistanceThreshold)
                //    {
                //        if (distance < settings.DistanceThreshold + settings.Range)
                //        {
                //            var result = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftShoulder.position);
                //            if (result < 0.5) return;
                //            maxDistance = result;
                //        }
                //        int i = 0;
                //        while (Vector3.Distance(references.VRIKLeftShoulder.position, leftHandAnchor.position) > maxDistance)
                //        {
                //            if (i > 9999)
                //                throw new Exception("What the fuck.");
                //            leftHandAnchor.position = Vector3.MoveTowards(leftHandAnchor.position, references.VRIKLeftShoulder.position, 0.05f);
                //        }
                //    }
                //}
                //{
                //    if (distance < 2 * settings.DistanceThreshold)
                //    {
                //        var result = Vector3.Distance(references.VRIKLeftHand.position, references.VRIKLeftShoulder.position);
                //        if (result < 0.6)
                //        {
                //        }
                //        else
                //            maxDistance = result;
                //    }
                //}
                //int i = 0;
                //while (Vector3.Distance(references.VRIKLeftShoulder.position, leftHandAnchor.position) > maxDistance)
                //{
                //    if (i > 9999)
                //        throw new Exception("What the fuck.");
                //    leftHandAnchor.position = Vector3.MoveTowards(leftHandAnchor.position, references.VRIKLeftShoulder.position, 0.05f);
                //}
                //references.VRIKLeftHand.position = leftHandAnchor.position;
                //references.VRIKRightHand.position = rightHandAnchor.position;
                //if (maxDistance == 99f)
                //{ // Max distance not yet set
                //    float distance;
                //    if (Vector3.Distance(LPrevious, leftHandAnchor.position) < settings.DistanceThreshold)
                //        if ((Vector3.Distance(leftHandAnchor.position, references.VRIKLeftHand.position)) > settings.DistanceThreshold)
                //        {                    // Limit
                //                             //maxDistance = Vector3.Distance(leftHandAnchor.position, references.VRIKLeftHand.position);
                //            leftHandAnchor.position = references.VRIKLeftHand.position;
                //            //leftHandAnchor.position = LPrevious;
                //            //distance = Vector3.Distance(references.VRIKLeftShoulder.position, references.VRIKLeftHand.position);
                //            //float dist2 = Vector3.Distance(references.VRIKLeftShoulder.position, leftHandAnchor.position);
                //            //var baizz = references.VRIKLeftShoulder.position;
                //            //var displacement = leftHandAnchor.position - references.VRIKLeftShoulder.position;
                //            //float division = distance / dist2;
                //            //var result = baizz + displacement * division;
                //            //leftHandAnchor.position = result;
                //            //// = references.VRIKLeftShoulder.position +                            (leftHandAnchor.position - references.VRIKLeftShoulder.position)                            * (distance / dist2);
                //            //float resultingDistance = Vector3.Distance(result, references.VRIKLeftHand.position);
                //            //if (true)
                //            //{
                //            //}
                //            // It's supposed to land exactly where VRIKLeftHand.position is, so why doesn't it???
                //            //leftHandAnchor.position = Vector3.MoveTowards(references.VRIKLeftShoulder.position, leftHandAnchor.position, distance);
                //        }
                //    if ((Vector3.Distance(rightHandAnchor.position, references.VRIKRightHand.position)) > settings.DistanceThreshold)
                //    {                    // Limit
                //                         //rightHandAnchor.position = references.VRIKRightHand.position;
                //                         //rightHandAnchor.position = RPrevious;
                //                         //maxDistance = Vector3.Distance(rightHandAnchor.position, references.VRIKRightHand.position);
                //        //distance = Vector3.Distance(references.VRIKRightShoulder.position, references.VRIKRightHand.position);
                //        //rightHandAnchor.position = Vector3.MoveTowards(references.VRIKRightShoulder.position, rightHandAnchor.position, distance);
                //        references.vrik
                //    }
                //}
                #endregion


            }
            #region Irrelevant
            trackerAnchor.localPosition = tracker.position;

            OVRPose leftOffsetPose = OVRPose.identity;
            OVRPose rightOffsetPose = OVRPose.identity;
            if (OVRManager.loadedXRDevice == OVRManager.XRDevice.OpenVR)
            {
                leftOffsetPose = OVRManager.GetOpenVRControllerOffset(Node.LeftHand);
                rightOffsetPose = OVRManager.GetOpenVRControllerOffset(Node.RightHand);

                //Sets poses of left and right nodes, local to the tracking space.
                OVRManager.SetOpenVRLocalPose(trackingSpace.InverseTransformPoint(leftControllerAnchor.position),
                    trackingSpace.InverseTransformPoint(rightControllerAnchor.position),
                    Quaternion.Inverse(trackingSpace.rotation) * leftControllerAnchor.rotation,
                    Quaternion.Inverse(trackingSpace.rotation) * rightControllerAnchor.rotation);
            }
            rightControllerAnchor.localPosition = rightOffsetPose.position;
            rightControllerAnchor.localRotation = rightOffsetPose.orientation;
            leftControllerAnchor.localPosition = leftOffsetPose.position;
            leftControllerAnchor.localRotation = leftOffsetPose.orientation;
        }

        RaiseUpdatedAnchorsEvent();
        #endregion
    }

}
