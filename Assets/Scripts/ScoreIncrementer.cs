using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreIncrementer : MonoBehaviour
{
    public GameObject score;
    private int scoreCounter = 0;
    private TMP_Text imputField;

    // Start is called before the first frame update
    void Start()
    {
        imputField = score.GetComponent<TMP_Text>();
    }


    public void IncreaseScore()
    {
        scoreCounter++;
        imputField.text = scoreCounter.ToString();
    }
}
