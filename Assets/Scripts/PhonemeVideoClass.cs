using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PhonemeVideoClass : MonoBehaviour
{
    public VideoClip clip;
    public string clipName = "LetterName";
    private int rHandHit = 0;
    private int lHandHit = 0;
    private bool enableRightHand = false;
    private bool enableLeftHand = false;
    public bool hasPlayed = false;
    public bool isPlaying = false;
    private int noOfPos = 0;
    private double posShiftTime = 0.0;
    private double posShiftTime2 = 0.0;
    private double posShiftTime3 = 0.0;
    private double posShiftTime4 = 0.0;
    private double visibleFromTime = 0.0;
    private bool visible = false; 
    private bool pos1ReadyToHit = false;
    private bool pos2ReadyToHit = false;
    private bool pos3ReadyToHit = false;
    private bool pos4ReadyToHit = false;
    private bool pos5ReadyToHit = false;
    private Vector3 rightHandpos1 = new Vector3(-0.1f, -0.2f, 0f);
    private Vector3 rightHandpos2 = new Vector3(-0.1f, -0.2f, 0f);
    private Vector3 rightHandpos3 = new Vector3(-0.1f, -0.2f, 0f);
    private Vector3 rightHandpos4 = new Vector3(-0.1f, -0.2f, 0f);
    private Vector3 rightHandpos5 = new Vector3(-0.1f, -0.2f, 0f);
    private Vector3 rightHandAngle1 = Vector3.zero;
    private Vector3 rightHandAngle2 = Vector3.zero;
    private Vector3 rightHandAngle3 = Vector3.zero;
    private Vector3 rightHandAngle4 = Vector3.zero;
    private Vector3 rightHandAngle5 = Vector3.zero;
    private Vector3 leftHandpos1 = new Vector3(0.1f, -0.2f, 0f);
    private Vector3 leftHandpos2 = new Vector3(0.1f, -0.2f, 0f);
    private Vector3 leftHandpos3 = new Vector3(0.1f, -0.2f, 0f);
    private Vector3 leftHandpos4 = new Vector3(0.1f, -0.2f, 0f);
    private Vector3 leftHandpos5 = new Vector3(0.1f, -0.2f, 0f);
    private Vector3 leftHandAngle1 = Vector3.zero;
    private Vector3 leftHandAngle2 = Vector3.zero;
    private Vector3 leftHandAngle3 = Vector3.zero;
    private Vector3 leftHandAngle4 = Vector3.zero;
    private Vector3 leftHandAngle5 = Vector3.zero;

    public PhonemeVideoClass (VideoClip clip)
    {
        this.clip = clip;
    }

    public void SetClipName (VideoClip clip)
    {
        this.clipName = clip.name; 
    }
    public string GetClipName()
    {
       return this.clipName;
    }
    public int GetRHandHit()
        { 
        return this.rHandHit;
    }
    public void SetRHandHit( int no)
    {
        this.rHandHit = no;
    }
    public void IncrRHandHit()
        { 
        this.rHandHit++; 
    }
    public int GetLHandHit()
    { 
        return this.lHandHit; 
    }
    public void SetLHandHit( int no)
    {
        this.lHandHit = no;
    }
    public void IncrLHandHit()
    { 
        this.lHandHit++; 
    }
    public void SetEnableRightHand(bool enable)
    {
        this.enableRightHand = enable;
    }
    public bool GetEnableRightHand()
    {
        return enableRightHand;
    }
    public void SetEnableLeftHand(bool enable)
    {
        this.enableLeftHand = enable;
    }
    public bool GetEnableLeftHand()
    {
        return enableLeftHand;
    }
    public void SetHasPlayed(bool hasPlayed)
    {
        this.hasPlayed = hasPlayed;
    }
    public bool GetHasPlayed()
    {
        return this.hasPlayed;
    }
    public void SetIsPlaying(bool isPlaying)
    {
        this.isPlaying = isPlaying;
    }
    public bool GetIsPlaying()
    {
        return this.isPlaying;
    }
    public void SetNoOfPos(int noOfPos)
    {
        this.noOfPos = noOfPos;
    }
    public int GetNoOfPos()
    {
        return this.noOfPos;
    }
    public void SetPosShiftTime(double posShiftTime)
    {
        this.posShiftTime = posShiftTime;
    }
    public double GetPosShiftTime()
    {
        return this.posShiftTime;
    }
    public void SetPosShiftTime2(double posShiftTime)
    {
        this.posShiftTime2 = posShiftTime;
    }
    public double GetPosShiftTime2()
    {
        return this.posShiftTime2;
    }
    public void SetPosShiftTime3(double posShiftTime)
    {
        this.posShiftTime3 = posShiftTime;
    }
    public double GetPosShiftTime3()
    {
        return this.posShiftTime3;
    }
    public void SetPosShiftTime4(double posShiftTime)
    {
        this.posShiftTime4 = posShiftTime;
    }
    public double GetPosShiftTime4()
    {
        return this.posShiftTime4;
    }
    public void SetVisibleFromTime(double visibleFromTime)
    {
        this.visibleFromTime = visibleFromTime;
    }
    public double GetVisibleFromTime()
    {
        return this.visibleFromTime;
    }
    public void SetVisible(bool visible)
    {
        this.visible = visible;
    }
    public bool GetVisible()
    {
        return this.visible;
    }
    public void SetPos1ReadyToHit(bool enable)
    {
        pos1ReadyToHit = enable; 
    }
    public bool GetPos1ReadyToHit()
    {
        return this.pos1ReadyToHit;
    }
    public void SetPos2ReadyToHit(bool enable)
    {
        pos2ReadyToHit = enable;
    }
    public bool GetPos2ReadyToHit()
    {
        return this.pos2ReadyToHit;
    }
    public void SetPos3ReadyToHit(bool enable)
    {
        pos3ReadyToHit = enable;
    }
    public bool GetPos3ReadyToHit()
    {
        return this.pos3ReadyToHit;
    }
    public void SetPos4ReadyToHit(bool enable)
    {
        pos4ReadyToHit = enable;
    }
    public bool GetPos4ReadyToHit()
    {
        return this.pos4ReadyToHit;
    }
    public void SetPos5ReadyToHit(bool enable)
    {
        pos5ReadyToHit = enable;
    }
    public bool GetPos5ReadyToHit()
    {
        return this.pos5ReadyToHit;
    }
    public void SetRightHandPos1(Vector3 pos)
    {
        this.rightHandpos1 = pos;
    }
    public Vector3 GetRightHandpos1()
    {
        return this.rightHandpos1;
    }
    public void SetRightHandPos2(Vector3 pos)
    {
        this.rightHandpos2 = pos;
    }
    public Vector3 GetRightHandpos2()
    {
        return this.rightHandpos2;
    }
    public void SetRightHandPos3(Vector3 pos)
    {
        this.rightHandpos3 = pos;
    }
    public Vector3 GetRightHandpos3()
    {
        return this.rightHandpos3;
    }
    public void SetRightHandPos4(Vector3 pos)
    {
        this.rightHandpos4 = pos;
    }
    public Vector3 GetRightHandpos4()
    {
        return this.rightHandpos4;
    }
    public void SetRightHandPos5(Vector3 pos)
    {
        this.rightHandpos5 = pos;
    }
    public Vector3 GetRightHandpos5()
    {
        return this.rightHandpos5;
    }
    public void SetLeftHandPos1(Vector3 pos)
    {
        this.leftHandpos1 = pos;
    }
    public Vector3 GetLeftHandpos1()
    {
        return this.leftHandpos1;
    }
    public void SetLeftHandPos2(Vector3 pos)
    {
        this.leftHandpos2 = pos;
    }
    public Vector3 GetLeftHandpos2()
    {
        return this.leftHandpos2;
    }
    public void SetLeftHandPos3(Vector3 pos)
    {
        this.leftHandpos3 = pos;
    }
    public Vector3 GetLeftHandpos3()
    {
        return this.leftHandpos3;
    }
    public void SetLeftHandPos4(Vector3 pos)
    {
        this.leftHandpos4 = pos;
    }
    public Vector3 GetLeftHandpos4()
    {
        return this.leftHandpos4;
    }
    public void SetLeftHandPos5(Vector3 pos)
    {
        this.leftHandpos5 = pos;
    }
    public Vector3 GetLeftHandpos5()
    {
        return this.leftHandpos5;
    }
    public void SetRightHandAngle1(Vector3 angle)
    {
        this.rightHandAngle1 = angle;
    }
    public Vector3 GetRightHandAngle1()
    {
        return this.rightHandAngle1;
    }
    public void SetRightHandAngle2(Vector3 angle)
    {
        this.rightHandAngle2 = angle;
    }
    public Vector3 GetRightHandAngle2()
    {
        return this.rightHandAngle2;
    }
    public void SetRightHandAngle3(Vector3 angle)
    {
        this.rightHandAngle3 = angle;
    }
    public Vector3 GetRightHandAngle3()
    {
        return this.rightHandAngle3;
    }
    public void SetRightHandAngle4(Vector3 angle)
    {
        this.rightHandAngle4 = angle;
    }
    public Vector3 GetRightHandAngle4()
    {
        return this.rightHandAngle4;
    }
    public void SetRightHandAngle5(Vector3 angle)
    {
        this.rightHandAngle5 = angle;
    }
    public Vector3 GetRightHandAngle5()
    {
        return this.rightHandAngle5;
    }
    public void SetLeftHandAngle1(Vector3 angle)
    {
        this.leftHandAngle1 = angle;
    }
    public Vector3 GetLeftHandAngle1()
    {
        return this.leftHandAngle1;
    }
    public void SetLeftHandAngle2(Vector3 pos)
    {
        this.leftHandAngle2 = pos;
    }
    public Vector3 GetLeftHandAngle2()
    {
        return this.leftHandAngle2;
    }
    public void SetLeftHandAngle3(Vector3 pos)
    {
        this.leftHandAngle3 = pos;
    }
    public Vector3 GetLeftHandAngle3()
    {
        return this.leftHandAngle3;
    }
    public void SetLeftHandAngle4(Vector3 pos)
    {
        this.leftHandAngle4 = pos;
    }
    public Vector3 GetLeftHandAngle4()
    {
        return this.leftHandAngle4;
    }
    public void SetLeftHandAngle5(Vector3 pos)
    {
        this.leftHandAngle5 = pos;
    }
    public Vector3 GetLeftHandAngle5()
    {
        return this.leftHandAngle5;
    }
}
