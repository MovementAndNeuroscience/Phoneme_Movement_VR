using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class PhonemeTaskConductor : MonoBehaviour
{
    public GameObject datalayer;
    public GameObject phonemeConductor;
    public bool allImagesPresented = false;
    public GameObject introText;
    public GameObject leftHandCollision;
    public GameObject rightHandCollision;
    public GameObject leftHandCollision2;
    public GameObject rightHandCollision2;
    public GameObject leftHandCollision3;
    public GameObject rightHandCollision3;
    public GameObject leftHandCollision4;
    public GameObject rightHandCollision4;
    public GameObject leftHandCollision5;
    public GameObject rightHandCollision5;
    public AudioClip plingSound;
    private TMP_Text text;
    private PicturePhonemeClass currentPicture;
    private bool leftHandCollided = false;
    private bool rightHandCollided = false;
    private bool leftHandCollided2 = false;
    private bool rightHandCollided2 = false;
    private bool leftHandCollided3 = false;
    private bool rightHandCollided3 = false;
    private bool leftHandCollided4 = false;
    private bool rightHandCollided4 = false;
    private bool leftHandCollided5 = false;
    private bool rightHandCollided5 = false;
    private bool pictureFound = false;
    private List<PicturePhonemeClass> pictureList = new List<PicturePhonemeClass>();
    private int totPictures = 0;
    private int presentedPictures = 0; 
    private Renderer thisRender;
    private float readytimer = 0.00f;
    private float startNextAssignment = 2.2f;
    private float pausetimer = 1.4f;
    private bool pos1; 
    private bool pos2;
    private bool pos3;
    private bool pos4;
    private bool pos5;


    // Start is called before the first frame update
    void Start()
    {
        pictureList = datalayer.GetComponent<PhonemeDb>().picturePhonemeList;
        pictureList = pictureList.OrderBy(x => Guid.NewGuid()).ToList();
        var tmpPictureList = new List<PicturePhonemeClass>();
        var i = 0;
        var j = 0;
        while ( i < pictureList.Count)
        {
            j = 0;

            while (j < datalayer.GetComponent<PhonemeDb>().activeLetters.Length)
            {
                if (pictureList[i].GetAssignmentLetter() == datalayer.GetComponent<PhonemeDb>().activeLetters[j].ToString())
                {
                    tmpPictureList.Add(pictureList[i]);
                    j = datalayer.GetComponent<PhonemeDb>().activeLetters.Length + 2; 
                }
                j++;
            }
            i++;
        }
        pictureList = tmpPictureList.OrderBy(x => Guid.NewGuid()).ToList();
        totPictures = pictureList.Count; 
        thisRender = this.GetComponent<Renderer>();
        text = introText.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        readytimer += Time.deltaTime;  

        if (pictureFound == false && readytimer < startNextAssignment)
        {
            readytimer = readytimer - readytimer;
            if (pictureList.Count == 0)
            {
                allImagesPresented = true;
            }
            if (pictureList.Count >= 1)
            {
                foreach (var picture in pictureList)
                {
                    currentPicture = picture;
                    pictureList.Remove(picture);
                    pictureFound = true;
                    presentedPictures++;

                    currentPicture = ResetPicture(currentPicture);

                    ActivateAll();

                    leftHandCollision.transform.position = currentPicture.GetLeftHandpos1();
                    rightHandCollision.transform.position = currentPicture.GetRightHandpos1();
                    leftHandCollision.transform.eulerAngles = currentPicture.GetLeftHandAngle1();
                    rightHandCollision.transform.eulerAngles = currentPicture.GetRightHandAngle1();

                    leftHandCollision2.transform.position = currentPicture.GetLeftHandpos2();
                    rightHandCollision2.transform.position = currentPicture.GetRightHandpos2();
                    leftHandCollision2.transform.eulerAngles = currentPicture.GetLeftHandAngle2();
                    rightHandCollision2.transform.eulerAngles = currentPicture.GetRightHandAngle2();

                    leftHandCollision3.transform.position = currentPicture.GetLeftHandpos3();
                    rightHandCollision3.transform.position = currentPicture.GetRightHandpos3();
                    leftHandCollision3.transform.eulerAngles = currentPicture.GetLeftHandAngle3();
                    rightHandCollision3.transform.eulerAngles = currentPicture.GetRightHandAngle3();

                    leftHandCollision4.transform.position = currentPicture.GetLeftHandpos4();
                    rightHandCollision4.transform.position = currentPicture.GetRightHandpos4();
                    leftHandCollision4.transform.eulerAngles = currentPicture.GetLeftHandAngle4();
                    rightHandCollision4.transform.eulerAngles = currentPicture.GetRightHandAngle4();

                    leftHandCollision5.transform.position = currentPicture.GetLeftHandpos5();
                    rightHandCollision5.transform.position = currentPicture.GetRightHandpos5();
                    leftHandCollision5.transform.eulerAngles = currentPicture.GetLeftHandAngle5();
                    rightHandCollision5.transform.eulerAngles = currentPicture.GetRightHandAngle5();

                    DeactivateAll();
                    pos1 = true;
                    break;
                }
            }
        }
        thisRender.material.mainTexture = currentPicture.image;
        text.text = currentPicture.GetAssignment();
        
        if (readytimer > startNextAssignment && readytimer < 999.0f)
        {
            if (currentPicture.GetNoOfPos() == 1 && currentPicture.GetLHandHit() == 0 && currentPicture.GetRHandHit() == 0)
            {
                ActivateCollision1();
                leftHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
                rightHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
                pictureFound = ReactOnTheLasPossibletCollision(leftHandCollided, rightHandCollided);
                readytimer = LastTargetHit(readytimer, pictureFound);

            }
            else if (currentPicture.GetNoOfPos() == 2)
            {

                if ((currentPicture.GetLHandHit() == 0 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 0 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if(pos1)
                    {
                        ActivateCollision1();                  
                        leftHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
                        rightHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
                        readytimer = ReactOnCollision(leftHandCollided, rightHandCollided, readytimer);
                        (pos1, pos2) = activateNextPosition(pos1, pos2);
                    }
                }
                else if ((currentPicture.GetLHandHit() == 1 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 1 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment) )
                {
                    if (pos2)
                    {
                        ActivateCollision2();
                        leftHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided2;
                        rightHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided2;
                        pictureFound = ReactOnTheLasPossibletCollision(leftHandCollided2, rightHandCollided2);
                        readytimer = LastTargetHit(readytimer, pictureFound);
                    }
                }

            }
            else if (currentPicture.GetNoOfPos() == 3)
            {

                if ((currentPicture.GetLHandHit() == 0 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 0 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos1)
                    {
                        ActivateCollision1();
                        leftHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
                        rightHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
                        readytimer = ReactOnCollision(leftHandCollided, rightHandCollided, readytimer);
                        (pos1, pos2) = activateNextPosition(pos1, pos2);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 1 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 1 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos2)
                    {
                        ActivateCollision2();
                        leftHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided2;
                        rightHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided2;
                        readytimer = ReactOnCollision(leftHandCollided2, rightHandCollided2, readytimer);
                        (pos2, pos3) = activateNextPosition(pos2, pos3);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 2 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 2 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos3)
                    {
                        ActivateCollision3();
                        leftHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided3;
                        rightHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided3;
                        pictureFound = ReactOnTheLasPossibletCollision(leftHandCollided3, rightHandCollided3);
                        readytimer = LastTargetHit(readytimer, pictureFound);
                    }
                }

            }
            else if (currentPicture.GetNoOfPos() == 4)
            {

                if ((currentPicture.GetLHandHit() == 0 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 0 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos1)
                    {
                        ActivateCollision1();
                        leftHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
                        rightHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
                        readytimer = ReactOnCollision(leftHandCollided, rightHandCollided, readytimer);
                        (pos1, pos2) = activateNextPosition(pos1, pos2);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 1 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 1 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos2)
                    {
                        ActivateCollision2();
                        leftHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided2;
                        rightHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided2;
                        readytimer = ReactOnCollision(leftHandCollided2, rightHandCollided2, readytimer);
                        (pos2, pos3) = activateNextPosition(pos2, pos3);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 2 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 2 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos3)
                    {
                        ActivateCollision3();
                        leftHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided3;
                        rightHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided3;
                        readytimer = ReactOnCollision(leftHandCollided3, rightHandCollided3, readytimer);
                        (pos3, pos4) = activateNextPosition(pos3, pos4);
                    }
                }
                else if ((currentPicture.GetLHandHit() == 3 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 3 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos4)
                    {
                        ActivateCollision4();
                        leftHandCollided4 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided4;
                        rightHandCollided4 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided4;
                        pictureFound = ReactOnTheLasPossibletCollision(leftHandCollided4, rightHandCollided4);
                        readytimer = LastTargetHit(readytimer, pictureFound);
                    }
                }
            }
            else if (currentPicture.GetNoOfPos() == 5)
            {

                if ((currentPicture.GetLHandHit() == 0 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 0 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos1)
                    {
                        ActivateCollision1();
                        leftHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
                        rightHandCollided = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
                        readytimer = ReactOnCollision(leftHandCollided, rightHandCollided, readytimer);
                        (pos1, pos2) = activateNextPosition(pos1, pos2);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 1 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 1 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos2)
                    {
                        ActivateCollision2();
                        leftHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided2;
                        rightHandCollided2 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided2;
                        readytimer = ReactOnCollision(leftHandCollided2, rightHandCollided2, readytimer);
                        (pos2, pos3) = activateNextPosition(pos2, pos3);
                    }
                }

                else if ((currentPicture.GetLHandHit() == 2 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 2 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos3)
                    {
                        ActivateCollision3();
                        leftHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided3;
                        rightHandCollided3 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided3;
                        readytimer = ReactOnCollision(leftHandCollided3, rightHandCollided3, readytimer);
                        (pos3, pos4) = activateNextPosition(pos3, pos4);
                    }
                }
                else if ((currentPicture.GetLHandHit() == 3 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 3 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos4)
                    {
                        ActivateCollision4();
                        leftHandCollided4 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided4;
                        rightHandCollided4 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided4;
                        readytimer = ReactOnCollision(leftHandCollided4, rightHandCollided4, readytimer);
                        (pos4, pos5) = activateNextPosition(pos4, pos5);
                    }
                }
                else if ((currentPicture.GetLHandHit() == 4 && currentPicture.GetEnableLeftHand() && readytimer > startNextAssignment) || (currentPicture.GetRHandHit() == 4 && currentPicture.GetEnableRightHand() && readytimer > startNextAssignment))
                {
                    if (pos5)
                    {
                        ActivateCollision5();
                        leftHandCollided5 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided5;
                        rightHandCollided5 = phonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided5;
                        pictureFound = ReactOnTheLasPossibletCollision(leftHandCollided5, rightHandCollided5);
                        readytimer = LastTargetHit(readytimer, pictureFound);
                    }
                }
            }
        }
        if (readytimer >= 999.6f)
        {
            ResetColliderPositions();
            ResetPositionActivation();
            readytimer = readytimer - 999.6f;
        }
    }

    private float LastTargetHit(float readytimer, bool pictureFound)
    {
        if (!pictureFound)
        {
            float noPics = presentedPictures;
            float totPic = totPictures;
            float percentagePicturesSucceeded = noPics / totPic;
            phonemeConductor.GetComponent<FeedbackChanger>().setFeedbackValue(percentagePicturesSucceeded);
            phonemeConductor.GetComponent<ScoreIncrementer>().IncreaseScore();
            AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
            return 999.0f;
        }
        return readytimer;
    }
    private PicturePhonemeClass ResetPicture (PicturePhonemeClass picture)
    {
        picture.SetLHandHit(0);
        picture.SetRHandHit(0); 
        return picture; 
    }
    private void ResetPositionActivation()
    {
        pos1 = false;
        pos2 = false;
        pos3 = false;
        pos4 = false;
        pos5 = false; 
    }
    private void ResetColliderPositions()
    {
        leftHandCollision.transform.position = new Vector3 (0.1f, -0.2f, 0f);
        rightHandCollision.transform.position = new Vector3 (-0.1f, -0.2f, 0f);

        leftHandCollision2.transform.position = new Vector3(0.1f, -0.2f, 0f);
        rightHandCollision2.transform.position = new Vector3(-0.1f, -0.2f, 0f);

        leftHandCollision3.transform.position = new Vector3(0.1f, -0.2f, 0f);
        rightHandCollision3.transform.position = new Vector3(-0.1f, -0.2f, 0f);

        leftHandCollision4.transform.position = new Vector3(0.1f, -0.2f, 0f);
        rightHandCollision4.transform.position = new Vector3(-0.1f, -0.2f, 0f);

        leftHandCollision5.transform.position = new Vector3(0.1f, -0.2f, 0f);
        rightHandCollision5.transform.position = new Vector3(-0.1f, -0.2f, 0f);
    }

    private void ActivateAll()
    {
        leftHandCollision.SetActive(true);
        rightHandCollision.SetActive(true);
        leftHandCollision2.SetActive(true);
        rightHandCollision2.SetActive(true);
        leftHandCollision3.SetActive(true);
        rightHandCollision3.SetActive(true);
        leftHandCollision4.SetActive(true);
        rightHandCollision4.SetActive(true);
        leftHandCollision5.SetActive(true);
        rightHandCollision5.SetActive(true);
    }
    private void DeactivateAll()
    {
        leftHandCollision.SetActive(false);
        rightHandCollision.SetActive(false);
        leftHandCollision2.SetActive(false);
        rightHandCollision2.SetActive(false);
        leftHandCollision3.SetActive(false);
        rightHandCollision3.SetActive(false);
        leftHandCollision4.SetActive(false);
        rightHandCollision4.SetActive(false);
        leftHandCollision5.SetActive(false);
        rightHandCollision5.SetActive(false);
    }
    private void ActivateCollision1()
    {
        leftHandCollision.SetActive(true);
        rightHandCollision.SetActive(true);
        leftHandCollision2.SetActive(false);
        rightHandCollision2.SetActive(false);
        leftHandCollision3.SetActive(false);
        rightHandCollision3.SetActive(false);
        leftHandCollision4.SetActive(false);
        rightHandCollision4.SetActive(false);
        leftHandCollision5.SetActive(false);
        rightHandCollision5.SetActive(false);
    }

    private void ActivateCollision2()
    {
        leftHandCollision.SetActive(false);
        rightHandCollision.SetActive(false);
        leftHandCollision2.SetActive(true);
        rightHandCollision2.SetActive(true);
        leftHandCollision3.SetActive(false);
        rightHandCollision3.SetActive(false);
        leftHandCollision4.SetActive(false);
        rightHandCollision4.SetActive(false);
        leftHandCollision5.SetActive(false);
        rightHandCollision5.SetActive(false);
    }
    private void ActivateCollision3()
    {
        leftHandCollision.SetActive(false);
        rightHandCollision.SetActive(false);
        leftHandCollision2.SetActive(false);
        rightHandCollision2.SetActive(false);
        leftHandCollision3.SetActive(true);
        rightHandCollision3.SetActive(true);
        leftHandCollision4.SetActive(false);
        rightHandCollision4.SetActive(false);
        leftHandCollision5.SetActive(false);
        rightHandCollision5.SetActive(false);
    }
    private void ActivateCollision4()
    {
        leftHandCollision.SetActive(false);
        rightHandCollision.SetActive(false);
        leftHandCollision2.SetActive(false);
        rightHandCollision2.SetActive(false);
        leftHandCollision3.SetActive(false);
        rightHandCollision3.SetActive(false);
        leftHandCollision4.SetActive(true);
        rightHandCollision4.SetActive(true);
        leftHandCollision5.SetActive(false);
        rightHandCollision5.SetActive(false);
    }
    private void ActivateCollision5()
    {
        leftHandCollision.SetActive(false);
        rightHandCollision.SetActive(false);
        leftHandCollision2.SetActive(false);
        rightHandCollision2.SetActive(false);
        leftHandCollision3.SetActive(false);
        rightHandCollision3.SetActive(false);
        leftHandCollision4.SetActive(false);
        rightHandCollision4.SetActive(false);
        leftHandCollision5.SetActive(true);
        rightHandCollision5.SetActive(true);
    }

    private float ReactOnCollision(bool collideLeft, bool collideRight, float time)
    {
        if (currentPicture.GetEnableLeftHand() && !currentPicture.GetEnableRightHand() && collideLeft && collideRight == false && time > startNextAssignment)
        {
            currentPicture.IncrLHandHit();
            return pausetimer; 
        }
        else if (!currentPicture.GetEnableLeftHand() && currentPicture.GetEnableRightHand() && collideRight && collideLeft == false && time > startNextAssignment)
        {
            currentPicture.IncrRHandHit();
            return pausetimer;
        }
        else if (currentPicture.GetEnableLeftHand() && currentPicture.GetEnableRightHand() && collideLeft && collideRight && time > startNextAssignment)
        {
            currentPicture.IncrLHandHit();
            currentPicture.IncrRHandHit();
            return pausetimer;
        }
        return time; 
    }

    private bool ReactOnTheLasPossibletCollision(bool collideLeft, bool collideRight)
    {
        if (currentPicture.GetEnableLeftHand() && !currentPicture.GetEnableRightHand() && collideLeft)
        {
            currentPicture.IncrLHandHit();
            return false;
        }
        else if (!currentPicture.GetEnableLeftHand() && currentPicture.GetEnableRightHand() && collideRight)
        {
            currentPicture.IncrRHandHit();
            return false;
        }
        else if (currentPicture.GetEnableLeftHand() && currentPicture.GetEnableRightHand() && collideLeft && collideRight)
        {
            currentPicture.IncrLHandHit();
            currentPicture.IncrRHandHit();
            return false;
        }
        return true; 
    }
    private (bool, bool) activateNextPosition (bool prevPos, bool nextPos)
    {
        if (readytimer == pausetimer)
        {
            nextPos = true;
            prevPos = false;
            return (prevPos, nextPos);
        }
        return (prevPos,nextPos); 
    }

    public PicturePhonemeClass GetCurrentPicture()
    {
        return currentPicture; 
    }
}
