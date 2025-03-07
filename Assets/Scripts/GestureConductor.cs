using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureConductor : MonoBehaviour
{
    public GameObject phonemeVideoPlane;
    public GameObject leftHandCollision; 
    public GameObject rightHandCollision;
    public GameObject l_hand_guide;
    public GameObject r_hand_guide;
    private UnityEngine.Video.VideoPlayer videoPlayer;
    private PhonemeVideoClass currentVideo; 

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = phonemeVideoPlane.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentVideo = phonemeVideoPlane.GetComponent<TutorialVideoConductor>().GetCurrentVideo();

        if (videoPlayer == null)
            videoPlayer = phonemeVideoPlane.GetComponent<UnityEngine.Video.VideoPlayer>();

        if (videoPlayer.clip.name != currentVideo.GetClipName())
        {
            videoPlayer = phonemeVideoPlane.GetComponent<UnityEngine.Video.VideoPlayer>();
        }

        
        l_hand_guide.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        r_hand_guide.transform.eulerAngles = new Vector3(180f, 0f, 0f);

        if (videoPlayer != null && videoPlayer.isPlaying && videoPlayer.time > currentVideo.GetVisibleFromTime())
        {
            currentVideo.SetVisible(true);

            if (videoPlayer.clip.name == "a")
            {
                AdjustTwoPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "b")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "d")
            {
                AdjustFivePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "e")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "g")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "i")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "k")
            {
                AdjustTwoPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "l")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "m")
            {
                AdjustFivePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "n")
            {
                AdjustOnePosition(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "o")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "r")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "s")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "t")
            {
                AdjustThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "uLyd1")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "uLyd2")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "vLyd1")
            {
                AdjustTwoPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "vLyd2")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "y")
            {
                AdjustOnePosition(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "ø")
            {
                AdjustOnePosition(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            if (videoPlayer.clip.name == "å")
            {
                AdjustFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
        }
        else
        {
            currentVideo.SetVisible(false);
            leftHandCollision.transform.position = new Vector3(0.0f, -1.0f, 0.0f); 
            leftHandCollision.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            rightHandCollision.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
            rightHandCollision.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
    //need for one pos and remember to add all the missing letters 
    private static void AdjustOnePosition(UnityEngine.Video.VideoPlayer videoPlayer, PhonemeVideoClass currentVideo, GameObject leftHandCollision, GameObject rightHandCollision)
    {
        if (videoPlayer.time > currentVideo.GetVisibleFromTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos1();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle1();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos1();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle1();
        }
    }

    private static void AdjustTwoPositions(UnityEngine.Video.VideoPlayer videoPlayer, PhonemeVideoClass currentVideo, GameObject leftHandCollision, GameObject rightHandCollision)
    {
        if (videoPlayer.time < currentVideo.GetPosShiftTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos1();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle1();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos1();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle1();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos2();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle2();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos2();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle2();
        }
    }
    private static void AdjustThreePositions(UnityEngine.Video.VideoPlayer videoPlayer, PhonemeVideoClass currentVideo, GameObject leftHandCollision, GameObject rightHandCollision)
    { 
        if (videoPlayer.time < currentVideo.GetPosShiftTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos1();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle1();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos1();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle1();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime() && videoPlayer.time < currentVideo.GetPosShiftTime2())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos2();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle2();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos2();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle2();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime2())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos3();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle3();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos3();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle3();
        }
    }
    private static void AdjustFourPositions(UnityEngine.Video.VideoPlayer videoPlayer, PhonemeVideoClass currentVideo, GameObject leftHandCollision, GameObject rightHandCollision)
    {
        if (videoPlayer.time < currentVideo.GetPosShiftTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos1();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle1();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos1();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle1();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime() && videoPlayer.time < currentVideo.GetPosShiftTime2())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos2();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle2();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos2();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle2();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime2() && videoPlayer.time < currentVideo.GetPosShiftTime3())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos3();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle3();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos3();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle3();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime3())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos4();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle4();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos4();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle4();
        }
    }

    private static void AdjustFivePositions(UnityEngine.Video.VideoPlayer videoPlayer, PhonemeVideoClass currentVideo, GameObject leftHandCollision, GameObject rightHandCollision)
    {
        if (videoPlayer.time < currentVideo.GetPosShiftTime())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos1();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle1();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos1();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle1();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime() && videoPlayer.time < currentVideo.GetPosShiftTime2())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos2();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle2();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos2();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle2();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime2() && videoPlayer.time < currentVideo.GetPosShiftTime3())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos3();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle3();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos3();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle3();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime3() && videoPlayer.time < currentVideo.GetPosShiftTime4())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos4();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle4();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos4();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle4();
        }
        else if (videoPlayer.time > currentVideo.GetPosShiftTime4())
        {
            leftHandCollision.transform.position = currentVideo.GetLeftHandpos5();
            leftHandCollision.transform.eulerAngles = currentVideo.GetLeftHandAngle5();
            rightHandCollision.transform.position = currentVideo.GetRightHandpos5();
            rightHandCollision.transform.eulerAngles = currentVideo.GetRightHandAngle5();
        }
    }
}
