using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    private static int selection = -1;

    public GameObject Male, Female;

    // Start is called before the first frame update
    void Start()
    {
        if (selection == 0)
            Male.SetActive(true);
        if (selection == 1)
            Female.SetActive(true);
    }

    public void SetGender(int i)
    {
        selection = i;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }


}
