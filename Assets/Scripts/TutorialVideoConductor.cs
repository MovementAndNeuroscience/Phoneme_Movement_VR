using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class TutorialVideoConductor : MonoBehaviour
{
    public GameObject phonemeconductor;
    public GameObject datalayer; 
    private PhonemeDb phonemeDb;
    public VideoPlayer videoPlayer;
    public AudioClip plingSound;
    public bool allLettersPresented = false;
    public string LettersToLearn = "a a a b b b e e e k k k l l l o o o s s s t t t å å å ";
    private PhonemeVideoClass currentVideo;
    private char[] letterArr; 
    private bool leftHandCollision = false;
    private bool rightHandCollision = false;
    private bool letterPlaying = false; 
    private LinkedList<char> foundLetters = new LinkedList<char>();  
    private bool letterFound = false;
    private double detectionDelayFactor = 0.1;
    private bool v1Found = false;
    private bool u1Found = false;  

    // Start is called before the first frame update
    void Start()
    {
        phonemeDb = datalayer.GetComponent<PhonemeDb>();

        if (phonemeDb.activeLetters != string.Empty)
        {
            var j = 0;
            var n = 0;
            var tempArr = phonemeDb.activeLetters.ToCharArray();
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] != ' ')
                {
                    j++; 
                }
            }
            letterArr = new char[j];
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] != ' ')
                {            
                    letterArr[n] = tempArr[i];
                    n++;
                }
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        leftHandCollision = phonemeconductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
        rightHandCollision = phonemeconductor.GetComponent<HandColliderCollisionDetection>().rightCollided;

        if (letterFound == false)
        {

            if(foundLetters.Count == letterArr.Length)
            {
                allLettersPresented = true;
            }
            var letterCounter = 0;
            currentVideo = new PhonemeVideoClass(phonemeDb.a); 
            foreach (var l in letterArr)
            {
                letterCounter++;
                if (letterCounter > foundLetters.Count)
                {
                    foreach (var phonemeVideo in phonemeDb.phonemeVideoList)
                    {
                        if (phonemeVideo.GetClipName() == "vLyd1" && l.ToString() == "v" && v1Found == false)
                        {
                            currentVideo = phonemeVideo;
                            letterFound = true;
                            foundLetters.AddLast(l);
                            v1Found = true;
                            break;
                        }
                        else if (phonemeVideo.GetClipName() == "vLyd2" && l.ToString() == "v")
                        {
                            currentVideo = phonemeVideo;
                            letterFound = true;
                            foundLetters.AddLast(l);
                            v1Found = false;
                            break;
                        }
                        else if (phonemeVideo.GetClipName() == "uLyd1" && l.ToString() == "u" && u1Found == false)
                        {
                            currentVideo = phonemeVideo;
                            letterFound = true;
                            foundLetters.AddLast(l);
                            u1Found = true;
                            break;
                        }
                        else if (phonemeVideo.GetClipName() == "uLyd2" && l.ToString() == "u")
                        {
                            currentVideo = phonemeVideo;
                            letterFound = true;
                            foundLetters.AddLast(l);
                            u1Found = false;
                            break;
                        }
                        else if (phonemeVideo.GetClipName() == l.ToString())
                        {
                            currentVideo = phonemeVideo;
                            letterFound = true;
                            foundLetters.AddLast(l);
                            break;
                        }
                    }
                }

                if (letterFound)
                {
                    break;
                }
            }
        }


        if (videoPlayer.clip.name != currentVideo.GetClipName())
        {
            if(currentVideo.GetClipName() == "vLyd1" || currentVideo.GetClipName() == "vLyd2" || currentVideo.GetClipName() == "uLyd1" || currentVideo.GetClipName() == "uLyd2")
                ResetProgressParameters();

            videoPlayer.clip = currentVideo.clip;
            if (!videoPlayer.isPlaying)
                videoPlayer.Play();

            letterPlaying = true;
        }
        else if (videoPlayer.clip.name == currentVideo.GetClipName() && !videoPlayer.isPlaying && letterPlaying == false)
        {
            videoPlayer.Play();
            ResetProgressParameters();
            letterPlaying = true;
        }

        if (currentVideo.GetEnableLeftHand() && currentVideo.GetEnableRightHand())
        {
            if (currentVideo.GetNoOfPos() == 1)
            {
                currentVideo = DetectHitOnePosition(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            else if (currentVideo.GetNoOfPos() == 2)
            {
                currentVideo = DetectHitTwPositions(videoPlayer,currentVideo,leftHandCollision, rightHandCollision);
            }
            else if(currentVideo.GetNoOfPos() == 3)
            {
                currentVideo = DetectHitThreePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            else if(currentVideo.GetNoOfPos() == 4)
            {
                currentVideo = DetectHitFourPositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }
            else if (currentVideo.GetNoOfPos() == 5)
            {
                currentVideo = DetectHitFivePositions(videoPlayer, currentVideo, leftHandCollision, rightHandCollision);
            }

            if (currentVideo.GetLHandHit() == currentVideo.GetNoOfPos() && currentVideo.GetRHandHit() == currentVideo.GetNoOfPos())
            {
                currentVideo.SetHasPlayed(true);
                videoPlayer.Stop();
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                float found = foundLetters.Count;
                float totLetters =  letterArr.Length;
                float procentageLetterFound = found / totLetters;
                phonemeconductor.GetComponent<FeedbackChanger>().setFeedbackValue(procentageLetterFound);
                letterFound = false;
                letterPlaying = false;
            }
        }
        if (currentVideo.GetEnableLeftHand() && currentVideo.GetEnableRightHand() == false)
        {
            if (currentVideo.GetNoOfPos() == 1)
            {
                currentVideo = DetectHitOnePosition(videoPlayer, currentVideo, leftHandCollision, 1);
            }
            else if (currentVideo.GetNoOfPos() == 2)
            {
                currentVideo = DetectHitTwPositions(videoPlayer, currentVideo, leftHandCollision, 1);
            }
            else if (currentVideo.GetNoOfPos() == 3)
            {
                currentVideo = DetectHitThreePositions(videoPlayer, currentVideo, leftHandCollision, 1);
            }
            else if (currentVideo.GetNoOfPos() == 4)
            {
                currentVideo = DetectHitFourPositions(videoPlayer, currentVideo, leftHandCollision, 1);
            }
            else if (currentVideo.GetNoOfPos() == 5)
            {
                currentVideo = DetectHitFivePositions(videoPlayer, currentVideo, leftHandCollision, 1);
            }

            if (currentVideo.GetLHandHit() == currentVideo.GetNoOfPos())
            {
                currentVideo.SetHasPlayed(true);
                videoPlayer.Stop();
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                float found = foundLetters.Count;
                float totLetters = letterArr.Length;
                float procentageLetterFound = found / totLetters;
                phonemeconductor.GetComponent<FeedbackChanger>().setFeedbackValue(procentageLetterFound);
                letterFound = false;
                letterPlaying = false;
            }
        }
        if (currentVideo.GetEnableLeftHand() == false && currentVideo.GetEnableRightHand())
        {
            if (currentVideo.GetNoOfPos() == 1)
            {
                currentVideo = DetectHitOnePosition(videoPlayer, currentVideo, rightHandCollision, 0);
            }
            else if (currentVideo.GetNoOfPos() == 2)
            {
                currentVideo = DetectHitTwPositions(videoPlayer, currentVideo, rightHandCollision, 0);
            }
            else if (currentVideo.GetNoOfPos() == 3)
            {
                currentVideo = DetectHitThreePositions(videoPlayer, currentVideo, rightHandCollision, 0);
            }
            else if (currentVideo.GetNoOfPos() == 4)
            {
                currentVideo = DetectHitFourPositions(videoPlayer, currentVideo, rightHandCollision, 0);
            }
            else if (currentVideo.GetNoOfPos() == 5)
            {
                currentVideo = DetectHitFivePositions(videoPlayer, currentVideo, rightHandCollision, 0);
            }

            if (currentVideo.GetRHandHit() == currentVideo.GetNoOfPos())
            {
                currentVideo.SetHasPlayed(true);
                videoPlayer.Stop();
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                float found = foundLetters.Count;
                float totLetters = letterArr.Length;
                float procentageLetterFound = found / totLetters;
                phonemeconductor.GetComponent<FeedbackChanger>().setFeedbackValue(procentageLetterFound);
                letterFound = false;
                letterPlaying = false;
            }
        }
        
    }

    private void ResetProgressParameters()
    {
        currentVideo.SetRHandHit(0);
        currentVideo.SetLHandHit(0);
        currentVideo.SetPos1ReadyToHit(true);
        currentVideo.SetPos2ReadyToHit(true);
        currentVideo.SetPos3ReadyToHit(true);
        currentVideo.SetPos4ReadyToHit(true);
        currentVideo.SetPos5ReadyToHit(true);
    }

    public PhonemeVideoClass GetCurrentVideo()
    {
        return currentVideo; 
    }
    private PhonemeVideoClass DetectHitOnePosition(VideoPlayer player, PhonemeVideoClass curVideo, bool lHandCollision, bool rHandCollision)
    {
        if (player.time > curVideo.GetVisibleFromTime() && curVideo.GetPos1ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set1PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }
    private PhonemeVideoClass DetectHitTwPositions(VideoPlayer player, PhonemeVideoClass curVideo, bool lHandCollision, bool rHandCollision)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set1PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set2PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }

    private PhonemeVideoClass DetectHitThreePositions(VideoPlayer player, PhonemeVideoClass curVideo, bool lHandCollision, bool rHandCollision)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set1PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set2PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set3PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }


    private PhonemeVideoClass DetectHitFourPositions(VideoPlayer player, PhonemeVideoClass curVideo, bool lHandCollision, bool rHandCollision)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set1PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set2PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor  && videoPlayer.time < curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set3PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos4ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set4PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }

    private PhonemeVideoClass DetectHitFivePositions(VideoPlayer player, PhonemeVideoClass curVideo, bool lHandCollision, bool rHandCollision)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set1PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set2PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set3PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime3() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime4() + detectionDelayFactor && curVideo.GetPos4ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set4PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime4() + detectionDelayFactor && curVideo.GetPos5ReadyToHit() && lHandCollision && rHandCollision)
        {
            Set5PosHit(curVideo);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }
    private static void Set5PosHit(PhonemeVideoClass curVideo)
    {
        curVideo.SetPos5ReadyToHit(false);
        curVideo.IncrLHandHit();
        curVideo.IncrRHandHit();
    }
    private static void Set4PosHit(PhonemeVideoClass curVideo)
    {
        curVideo.SetPos4ReadyToHit(false);
        curVideo.IncrLHandHit();
        curVideo.IncrRHandHit();
    }
    private static void Set3PosHit(PhonemeVideoClass curVideo)
    {
        curVideo.SetPos3ReadyToHit(false);
        curVideo.IncrLHandHit();
        curVideo.IncrRHandHit();
    }
    private static void Set2PosHit(PhonemeVideoClass curVideo)
    {
        curVideo.SetPos2ReadyToHit(false);
        curVideo.IncrLHandHit();
        curVideo.IncrRHandHit();
    }

    private static void Set1PosHit(PhonemeVideoClass curVideo)
    {
        curVideo.SetPos1ReadyToHit(false);
        curVideo.IncrLHandHit();
        curVideo.IncrRHandHit();
    }

    //hand = 1 = Left hand collision
    //hand = 0 = Right hand collision
    private PhonemeVideoClass DetectHitOnePosition(VideoPlayer player, PhonemeVideoClass curVideo, bool handCollision, int hand)
    {
        if (player.time > curVideo.GetVisibleFromTime() && curVideo.GetPos1ReadyToHit() && handCollision)
        {
            Set1PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }
    private PhonemeVideoClass DetectHitTwPositions(VideoPlayer player, PhonemeVideoClass curVideo, bool handCollision, int hand)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && handCollision)
        {
            Set1PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && handCollision)
        {
            Set2PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }
    private PhonemeVideoClass DetectHitThreePositions(VideoPlayer player, PhonemeVideoClass curVideo, bool handCollision, int hand)
    {
        if (player.time < curVideo.GetPosShiftTime()+ detectionDelayFactor && curVideo.GetPos1ReadyToHit() && handCollision)
        {
            Set1PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor  && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor  && curVideo.GetPos2ReadyToHit() && handCollision)
        {
            Set2PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && handCollision)
        {
            Set3PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }

    private PhonemeVideoClass DetectHitFourPositions(VideoPlayer player, PhonemeVideoClass curVideo, bool handCollision, int hand)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && handCollision)
        {
            Set1PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && handCollision)
        {
            Set2PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && handCollision)
        {
            Set3PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos4ReadyToHit() && handCollision)
        {
            Set4PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }

    private PhonemeVideoClass DetectHitFivePositions(VideoPlayer player, PhonemeVideoClass curVideo, bool handCollision, int hand)
    {
        if (player.time < curVideo.GetPosShiftTime() + detectionDelayFactor && curVideo.GetPos1ReadyToHit() && handCollision)
        {
            Set1PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime2() + detectionDelayFactor && curVideo.GetPos2ReadyToHit() && handCollision)
        {
            Set2PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime2() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime3() + detectionDelayFactor && curVideo.GetPos3ReadyToHit() && handCollision)
        {
            Set3PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime3() + detectionDelayFactor && videoPlayer.time < curVideo.GetPosShiftTime4() + detectionDelayFactor && curVideo.GetPos4ReadyToHit() && handCollision)
        {
            Set4PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        else if (videoPlayer.time > curVideo.GetPosShiftTime4() + detectionDelayFactor && curVideo.GetPos5ReadyToHit() && handCollision)
        {
            Set5PosHit(curVideo, hand);
            phonemeconductor.GetComponent<ScoreIncrementer>().IncreaseScore();
        }
        return curVideo;
    }

    private static void Set5PosHit(PhonemeVideoClass curVideo, int hand)
    {
        curVideo.SetPos5ReadyToHit(false);
        if (hand == 1)
            curVideo.IncrLHandHit();
        else if (hand == 0)
            curVideo.IncrRHandHit();
    }
    private static void Set4PosHit(PhonemeVideoClass curVideo, int hand)
    {
        curVideo.SetPos4ReadyToHit(false);
        if (hand == 1)
            curVideo.IncrLHandHit();
        else if (hand == 0)
            curVideo.IncrRHandHit();
    }
    private static void Set3PosHit(PhonemeVideoClass curVideo, int hand)
    {
        curVideo.SetPos3ReadyToHit(false);
        if (hand == 1)
            curVideo.IncrLHandHit();
        else if (hand == 0)
            curVideo.IncrRHandHit();
    }
    private static void Set2PosHit(PhonemeVideoClass curVideo, int hand)
    {
        curVideo.SetPos2ReadyToHit(false);
        if (hand == 1)
            curVideo.IncrLHandHit();
        else if (hand == 0)
            curVideo.IncrRHandHit();
    }

    private static void Set1PosHit(PhonemeVideoClass curVideo, int hand)
    {
        curVideo.SetPos1ReadyToHit(false);

        if (hand == 1)
            curVideo.IncrLHandHit();
        else if (hand == 0)
            curVideo.IncrRHandHit();
    }
}
