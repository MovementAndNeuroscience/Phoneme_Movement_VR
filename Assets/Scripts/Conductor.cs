using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Conductor : MonoBehaviour
{
    public GameObject l_Hand_Guidance;
    public GameObject r_Hand_Guidance;
    public GameObject phoneme_video_plane;
    public GameObject l_Hand_Collision; 
    public GameObject r_Hand_Collision;
    public GameObject l_Hand_Collision2;
    public GameObject r_Hand_Collision2;
    public GameObject l_Hand_Collision3;
    public GameObject r_Hand_Collision3;
    public GameObject l_Hand_Collision4;
    public GameObject r_Hand_Collision4;
    public GameObject l_Hand_Collision5;
    public GameObject r_Hand_Collision5;
    public GameObject phoneme_Conductor;
    public GameObject scorecounter;
    public GameObject introText;
    public GameObject dataLayer;
    public GameObject phonemePicturePlane;
    public GameObject calibrationConductor;
    public GameObject menu; 
    public GameObject caliStar;
    public GameObject tutStar;
    public GameObject taskStar;
    private TMP_Text text;
    private bool activateTutorial = false;
    private bool tutorialHasPlayed = false;
    private bool activateTaskMode = false;
    private bool taskModeHasPlayed = false;
    private bool activateCalibraion = true;
    private bool calibrationHasPlayed = false;
    private bool prepForTurorial = true;
    private bool menuMode = false;
    // Start is called before the first frame update
    void Start()
    {
        dataLayer.SetActive(true);
        l_Hand_Guidance.SetActive(false);
        r_Hand_Guidance.SetActive(false);
        phoneme_video_plane.SetActive(false);
        l_Hand_Collision.SetActive(false);
        r_Hand_Collision.SetActive(false);
        l_Hand_Collision2.SetActive(false);
        r_Hand_Collision2.SetActive(false);
        l_Hand_Collision3.SetActive(false);
        r_Hand_Collision3.SetActive(false);
        l_Hand_Collision4.SetActive(false);
        r_Hand_Collision4.SetActive(false);
        l_Hand_Collision5.SetActive(false);
        r_Hand_Collision5.SetActive(false);
        scorecounter.SetActive(false);
        phoneme_Conductor.SetActive(false);
        phonemePicturePlane.SetActive(false);
        calibrationConductor.SetActive(false);
        caliStar.SetActive(false);
        tutStar.SetActive(false);
        taskStar.SetActive(false);
        menu.SetActive(false); 
        activateTutorial = true;
        text = introText.GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {

        tutorialHasPlayed = phoneme_video_plane.GetComponent<TutorialVideoConductor>().allLettersPresented;
        taskModeHasPlayed = phonemePicturePlane.GetComponent<PhonemeTaskConductor>().allImagesPresented;
        calibrationHasPlayed = calibrationConductor.GetComponent<Calibration>().calibrationDone;
        //Calibration mode 

        if ((OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch) && calibrationHasPlayed == false && activateCalibraion == true) || (Input.GetKeyDown(KeyCode.A) && calibrationHasPlayed == false && activateCalibraion == true))
        {
            l_Hand_Guidance.SetActive(true);
            r_Hand_Guidance.SetActive(true);
            l_Hand_Collision.SetActive(true);
            r_Hand_Collision.SetActive(true);
            calibrationConductor.SetActive(true);
            phoneme_Conductor.SetActive(true);
            scorecounter.SetActive(true);
            phoneme_Conductor.GetComponent<GestureConductor>().enabled = false;
            phoneme_Conductor.GetComponent<MaterialChanger>().calibrationMode = true;
            activateTutorial = false;
            text.text = "Rør kasserne med pindene";
        }


        if (calibrationHasPlayed && activateTutorial == false && prepForTurorial)
        {
            caliStar.SetActive(true);
            l_Hand_Guidance.SetActive(false);
            r_Hand_Guidance.SetActive(false);
            calibrationConductor.SetActive(false);
            l_Hand_Collision.SetActive(false);
            r_Hand_Collision.SetActive(false);
            scorecounter.SetActive(true);
            phoneme_Conductor.GetComponent<MaterialChanger>().calibrationMode = false;
            text.text = " Godt gået!\ndu er klar til at lære lyd bevægelser \nTryk på A for at starte";
            activateTutorial = true;
            prepForTurorial = false;
        }



        if ((OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch) && tutorialHasPlayed == false && activateTutorial == true) ||( Input.GetKeyDown(KeyCode.A) && tutorialHasPlayed == false && activateTutorial == true))
        {
            l_Hand_Guidance.SetActive(true);
            r_Hand_Guidance.SetActive(true);
            phoneme_video_plane.SetActive(true);
            l_Hand_Collision.SetActive(true);
            r_Hand_Collision.SetActive(true);
            phoneme_Conductor.SetActive(true);
            phoneme_Conductor.GetComponent<GestureConductor>().enabled = true;
            phoneme_Conductor.GetComponent<MaterialChanger>().tutorialMode = true;
            phoneme_Conductor.GetComponent<FeedbackChanger>().setFeedbackValue(0.0f); 
            scorecounter.SetActive(true);
            activateTutorial = false;
            text.text = " ";
        }


        if(tutorialHasPlayed && activateTaskMode == false)
        {
            tutStar.SetActive(true);
            l_Hand_Guidance.SetActive(false);
            r_Hand_Guidance.SetActive(false);
            phoneme_video_plane.SetActive(false);
            l_Hand_Collision.SetActive(false);
            r_Hand_Collision.SetActive(false);
            phoneme_Conductor.SetActive(false);
            scorecounter.SetActive(false);
            phoneme_Conductor.GetComponent<MaterialChanger>().tutorialMode = false;
            text.text = " Nu er du klar til spillet \nTryk på A for at starte";
            activateTaskMode = true; 
        }
        if ((OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch) && taskModeHasPlayed == false && activateTaskMode == true) || (Input.GetKeyDown(KeyCode.A) && taskModeHasPlayed == false && activateTaskMode == true))
        {

            l_Hand_Guidance.SetActive(true);
            r_Hand_Guidance.SetActive(true);
            phoneme_video_plane.SetActive(false);
            l_Hand_Collision.SetActive(true);
            r_Hand_Collision.SetActive(true);
            phoneme_Conductor.SetActive(true);
            phoneme_Conductor.GetComponent<GestureConductor>().enabled = false; 
            phoneme_Conductor.GetComponent<MaterialChanger>().taskMode = true;
            phoneme_Conductor.GetComponent<FeedbackChanger>().setFeedbackValue(0.0f);
            phonemePicturePlane.SetActive(true);
            scorecounter.SetActive(true);
            activateTutorial = false;
            text.text = " ";
        }

        if (taskModeHasPlayed && menuMode == false)
        {
            taskStar.SetActive(true);
            l_Hand_Guidance.SetActive(false);
            r_Hand_Guidance.SetActive(false);
            phoneme_video_plane.SetActive(false);
            l_Hand_Collision.SetActive(false);
            r_Hand_Collision.SetActive(false);
            phoneme_Conductor.SetActive(false);
            scorecounter.SetActive(false);
            phonemePicturePlane.SetActive(false);
            phoneme_Conductor.GetComponent<MaterialChanger>().taskMode = false;
            text.text = " Tillykke du har gennemført spillet" +
                "\n Tryk på A for at vælge et nyt spil";
        }
        if ((OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch) && taskModeHasPlayed && menuMode == false) || (Input.GetKeyDown(KeyCode.A) && taskModeHasPlayed && menuMode == false))
        {
            r_Hand_Guidance.SetActive(true);
            l_Hand_Guidance.SetActive(true);
            phoneme_Conductor.SetActive(true);
            menu.SetActive(true);
            menuMode = true; 
        }


    }
}
