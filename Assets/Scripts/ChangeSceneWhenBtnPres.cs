using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneWhenBtnPres : MonoBehaviour
{
    public string se_sceneName;
    public string laa_sceneName;
    public string ot_sceneName;
    public string kab_sceneName;
    public string mu_sceneName;
    public string rin_sceneName;
    public string dy_sceneName;
    public string voog_sceneName;
    public string all_sceneName;
    public GameObject lHandGuide;
    public GameObject rHandGuide;
    public GameObject se_btnCollider;
    public GameObject laa_btnCollider;
    public GameObject ot_btnCollider;
    public GameObject kab_btnCollider;
    public GameObject mu_btnCollider;
    public GameObject rin_btnCollider;
    public GameObject dy_btnCollider;
    public GameObject voog_btnCollider;
    public GameObject all_btnCollider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (CollisionDetection(lHandGuide, se_btnCollider) || CollisionDetection(rHandGuide, se_btnCollider))
        {

            if(OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
                SceneManager.LoadScene(se_sceneName);
        }
        else if (CollisionDetection(lHandGuide, laa_btnCollider) || CollisionDetection(rHandGuide, laa_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(laa_sceneName);
        }
        else if (CollisionDetection(lHandGuide, ot_btnCollider) || CollisionDetection(rHandGuide, ot_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(ot_sceneName);
        }
        else if (CollisionDetection(lHandGuide, kab_btnCollider) || CollisionDetection(rHandGuide, kab_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(kab_sceneName);
        }
        else if (CollisionDetection(lHandGuide, mu_btnCollider) || CollisionDetection(rHandGuide, mu_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(mu_sceneName);
        }
        else if (CollisionDetection(lHandGuide, rin_btnCollider) || CollisionDetection(rHandGuide, rin_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(rin_sceneName);
        }
        else if (CollisionDetection(lHandGuide, dy_btnCollider) || CollisionDetection(rHandGuide, dy_btnCollider))
        {
            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
                SceneManager.LoadScene(dy_sceneName);
        }
        else if (CollisionDetection(lHandGuide, voog_btnCollider) || CollisionDetection(rHandGuide, voog_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(voog_sceneName);
        }
        else if (CollisionDetection(lHandGuide, all_btnCollider) || CollisionDetection(rHandGuide, all_btnCollider))
        {

            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.A))
            SceneManager.LoadScene(all_sceneName);
        }
    }

    private bool CollisionDetection(GameObject hand, GameObject btn)
    {
        if (btn.transform.position.x + 0.220f > hand.transform.position.x && btn.transform.position.x - 0.250f < hand.transform.position.x &&
            btn.transform.position.y + 0.040f > hand.transform.position.y && btn.transform.position.y - 0.040f < hand.transform.position.y)
        {
            return true;
        }
        return false;
    }
}
