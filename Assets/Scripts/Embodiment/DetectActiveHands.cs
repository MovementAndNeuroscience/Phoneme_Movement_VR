using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectActiveHands : MonoBehaviour
{
    public GameObject Panel;
    public float TimeInterval = 1f;

    private bool previousResult = false;

    public GameObject[] DisableOnInactiveHands;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeInterval);

            bool result = (OVRInput.GetActiveController() != OVRInput.Controller.Touch);

            Panel.SetActive(previousResult && result);

            foreach (GameObject g in DisableOnInactiveHands)
                g.SetActive(!Panel.activeSelf);

            previousResult = result;
        }
    }

}

//public class DetectActiveHands : MonoBehaviour
//{
//    public FormsManager fm;

//    // Start is called before the first frame update
//    void Start()
//    {
//        InvokeRepeating("CheckNoHands", 1f, 1f);  //1s delay, repeat every 1s
//    }

//    void CheckNoHands()
//    {
//        OVRInput.Controller activeController = OVRInput.GetActiveController();
//        if (activeController != OVRInput.Controller.Touch)
//        {
//            fm.ShowMessage("Oculus Controllers", "Please pick up the oculus controllers");
//        } else
//        {
//            //fm.HideMessage();
//            fm.ShowForm(FormsManager.FormType.Messages, false);
//        }

//        Debug.Log("CheckNoHands::" + activeController);
//    }

//}
