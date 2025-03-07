using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Calibration : MonoBehaviour
{
    public GameObject leftHAndCollision; 
    public GameObject rightHAndCollision;
    public bool calibrationDone = false;
    public GameObject PhonemeConductor;
    public AudioClip plingSound;
    public GameObject feedbackSlider;
    public GameObject feebackFillArea;
    public GameObject feedbackHandle; 
    private bool leftCollided = false;
    private bool rightCollided = false;
    private int calibrationpos = 1;
    private float timer = 0.0f;
    private float fbSliderValue = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftCollided = PhonemeConductor.GetComponent<HandColliderCollisionDetection>().leftCollided;
        rightCollided = PhonemeConductor.GetComponent<HandColliderCollisionDetection>().rightCollided;
        timer += Time.deltaTime; 
        
        if (calibrationpos == 1)
        {
            leftHAndCollision.transform.position = new Vector3 (0.091f, 1.582f, -0.7751f);
            rightHAndCollision.transform.position = new Vector3 (-0.091f, 1.582f, -0.7751f);
            leftHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);
            rightHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);

            if(leftCollided && rightCollided && timer > 1.0f)
            {
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                calibrationpos = 2;
                timer = 0.0f;
                fbSliderValue = 1.0f / 3.0f;
                PhonemeConductor.GetComponent<FeedbackChanger>().setFeedbackValue(fbSliderValue);
                PhonemeConductor.GetComponent<ScoreIncrementer>().IncreaseScore();
            }
        }

        if (calibrationpos == 2)
        {
            leftHAndCollision.transform.position = new Vector3(0.550f, 1.17f, -0.7751f);
            rightHAndCollision.transform.position = new Vector3(-0.550f, 1.17f, -0.7751f);
            leftHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);
            rightHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);

            if (leftCollided && rightCollided && timer > 1.0f)
            {
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                calibrationpos = 3;
                timer = 0.0f;
                fbSliderValue = 2.0f / 3.0f;
                PhonemeConductor.GetComponent<FeedbackChanger>().setFeedbackValue(fbSliderValue);
                PhonemeConductor.GetComponent<ScoreIncrementer>().IncreaseScore();
            }
        }

        if (calibrationpos == 3)
        {
            leftHAndCollision.transform.position = new Vector3(0.437f, 0.769f, -0.7751f);
            rightHAndCollision.transform.position = new Vector3(-0.437f, 0.769f, -0.7751f);
            leftHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);
            rightHAndCollision.transform.eulerAngles = new Vector3(0, 0, 0);

            if (leftCollided && rightCollided && timer > 1.0f)
            {
                AudioSource.PlayClipAtPoint(plingSound, new Vector3(0.0f, 0.0f, 0.0f));
                calibrationpos = 4;
                timer = 0.0f;
                fbSliderValue = 3.0f / 3.0f;
                PhonemeConductor.GetComponent<FeedbackChanger>().setFeedbackValue(fbSliderValue);
                PhonemeConductor.GetComponent<ScoreIncrementer>().IncreaseScore();
                calibrationDone = true; 
            }
        }
    }
}
