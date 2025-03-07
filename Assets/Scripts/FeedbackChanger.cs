using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackChanger : MonoBehaviour
{
    public GameObject feedbackSlider;
    public GameObject feebackFillArea;
    public GameObject feedbackHandle;
    public float feedbackValue = 0.0f; 
    // Start is called before the first frame update

    public void setFeedbackValue(float fbValue)
    {
        var slider = feedbackSlider.GetComponent<Slider>();
        slider.value = fbValue;
        feedbackHandle.GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, fbValue);
        feebackFillArea.GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, fbValue);

    }

}
