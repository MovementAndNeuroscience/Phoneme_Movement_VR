using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipIntroScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LThumbstick) || OVRInput.Get(OVRInput.RawButton.RThumbstick) || Input.GetKey(KeyCode.Alpha1))
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
