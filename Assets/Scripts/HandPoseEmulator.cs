using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPoseEmulator : MonoBehaviour
{
    [SerializeField] Hand sourceHand;
    [SerializeField] Hand puppetHand;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        while (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) != 0 || OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) != 0)
            yield return null;

        sourceHand.Init();
        puppetHand.Init();
    }

    //public void Update()
    //{
    //    if (OVRInput.GetDown(OVRInput.RawButton.A))
    //        Start();
    //}


    private void LateUpdate() { puppetHand.Puppeteer(sourceHand); }

    [System.Serializable]
    private class Hand
    {
        private readonly int boneDepth = 2;
        public Transform[] FingerTransforms;
        private Transform[,] bones;
        private Quaternion[,] StartRotation;
        public float[] fingerStrength = new float[5] { 1, 1, 1, 1, 1 };

        private float[,] zRotations;

        public void Init()
        {


            bones = new Transform[FingerTransforms.Length, boneDepth];
            StartRotation = new Quaternion[FingerTransforms.Length, boneDepth];
            zRotations = new float[FingerTransforms.Length, boneDepth];

            for (int finger = 0; finger < FingerTransforms.Length; ++finger)
            {
                bones[finger, 0] = FingerTransforms[finger];
                StartRotation[finger, 0] = bones[finger, 0].localRotation;
                zRotations[finger, 0] = bones[finger, 0].localEulerAngles.z;

                if (boneDepth < 2) continue;
                bones[finger, 1] = bones[finger, 0].GetChild(0);
                StartRotation[finger, 1] = bones[finger, 1].localRotation;
                zRotations[finger, 1] = bones[finger, 1].localEulerAngles.z;

                if (boneDepth < 3) continue;
                bones[finger, 2] = bones[finger, 1].GetChild(0);
                StartRotation[finger, 2] = bones[finger, 2].localRotation;
                zRotations[finger, 2] = bones[finger, 2].localEulerAngles.z;
            }
        }

        public void Puppeteer(Hand source)
        {
            // https://forum.unity.com/threads/get-the-difference-between-two-quaternions-and-add-it-to-another-quaternion.513187/

            if (bones == null) return;

            for (int finger = 0; finger < FingerTransforms.Length; ++finger)
                for (int bone = 0; bone < boneDepth; ++bone)
                    if (finger < 1)
                        SolveQuaternion(finger, bone);
                    else
                        SolveZ(finger, bone);


            void SolveQuaternion(int finger, int bone)
            {
                Quaternion localRotationDifferenceIndex =
    source.bones[finger, bone].localRotation * Quaternion.Inverse(source.StartRotation[finger, bone]);

                bones[finger, bone].localRotation = StartRotation[finger, bone] * localRotationDifferenceIndex;
            }

            void SolveZ(int finger, int bone)
            {
                float diff = source.bones[finger, bone].localEulerAngles.z - source.zRotations[finger, bone];

                bones[finger, bone].localEulerAngles = StartRotation[finger, bone].eulerAngles + new Vector3(0, 0, diff) * fingerStrength[finger];
            }
        }




    }
}
