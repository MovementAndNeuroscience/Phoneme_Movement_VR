using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public GameObject leftOutlineCube;
    public GameObject rightOutlineCube;
    public GameObject leftOutlineCube2;
    public GameObject rightOutlineCube2;
    public GameObject leftOutlineCube3;
    public GameObject rightOutlineCube3;
    public GameObject leftOutlineCube4;
    public GameObject rightOutlineCube4;
    public GameObject leftOutlineCube5;
    public GameObject rightOutlineCube5;
    public GameObject phonemeVideoPlane;
    public bool tutorialMode = false;
    public bool taskMode = false; 
    public bool calibrationMode = false;
    private bool leftHandCollision = false;
    private bool rightHandCollision = false;
    private bool leftHandCollision2 = false;
    private bool rightHandCollision2 = false;
    private bool leftHandCollision3 = false;
    private bool rightHandCollision3 = false;
    private bool leftHandCollision4 = false;
    private bool rightHandCollision4 = false;
    private bool leftHandCollision5 = false;
    private bool rightHandCollision5 = false;
    private Renderer lOutlineRenderer; 
    private Renderer rOutlineRenderer;
    private Renderer lOutlineRenderer2;
    private Renderer rOutlineRenderer2;
    private Renderer lOutlineRenderer3;
    private Renderer rOutlineRenderer3;
    private Renderer lOutlineRenderer4;
    private Renderer rOutlineRenderer4;
    private Renderer lOutlineRenderer5;
    private Renderer rOutlineRenderer5;
    private PhonemeVideoClass currentVideo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHandCollision = GetComponent<HandColliderCollisionDetection>().leftCollided;
        rightHandCollision = GetComponent<HandColliderCollisionDetection>().rightCollided;
        leftHandCollision2 = GetComponent<HandColliderCollisionDetection>().leftCollided2;
        rightHandCollision2 = GetComponent<HandColliderCollisionDetection>().rightCollided2;
        leftHandCollision3 = GetComponent<HandColliderCollisionDetection>().leftCollided3;
        rightHandCollision3 = GetComponent<HandColliderCollisionDetection>().rightCollided3;
        leftHandCollision4 = GetComponent<HandColliderCollisionDetection>().leftCollided4;
        rightHandCollision4 = GetComponent<HandColliderCollisionDetection>().rightCollided4;
        leftHandCollision5 = GetComponent<HandColliderCollisionDetection>().leftCollided5;
        rightHandCollision5 = GetComponent<HandColliderCollisionDetection>().rightCollided5;
        lOutlineRenderer = leftOutlineCube.GetComponent<Renderer>();
        rOutlineRenderer = rightOutlineCube.GetComponent<Renderer>();
        lOutlineRenderer2 = leftOutlineCube2.GetComponent<Renderer>();
        rOutlineRenderer2 = rightOutlineCube2.GetComponent<Renderer>();
        lOutlineRenderer3 = leftOutlineCube3.GetComponent<Renderer>();
        rOutlineRenderer3 = rightOutlineCube3.GetComponent<Renderer>();
        lOutlineRenderer4 = leftOutlineCube4.GetComponent<Renderer>();
        rOutlineRenderer4 = rightOutlineCube4.GetComponent<Renderer>();
        lOutlineRenderer5 = leftOutlineCube5.GetComponent<Renderer>();
        rOutlineRenderer5 = rightOutlineCube5.GetComponent<Renderer>();

        if (tutorialMode)
        {
            currentVideo = phonemeVideoPlane.GetComponent<TutorialVideoConductor>().GetCurrentVideo();
            var visible = currentVideo.GetVisible();
            if (leftHandCollision && visible)
            {
                
                lOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else if (visible)
            {
                lOutlineRenderer.material.SetColor("_Color", new Color(1.0f, 0.0f, 0.0f, 1.0f));
            }
            else
            {
                lOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (rightHandCollision && visible)
            {
                
                rOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else if (visible)
            {
                rOutlineRenderer.material.SetColor("_Color", new Color(1.0f, 0.0f, 0.0f, 1.0f));
            }
            else
            {
                rOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }
        }

        if(taskMode)
        {
            if (leftHandCollision)
            {
                lOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f,1.0f));
            }
            else
            {
                lOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f,0.0f));
            }

            if (rightHandCollision)
            {
                rOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f,1.0f));
            }
            else
            {
                rOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f,0.0f));
            }
            
            if (leftHandCollision2)
            {
                lOutlineRenderer2.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                lOutlineRenderer2.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (rightHandCollision2)
            {
                rOutlineRenderer2.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                rOutlineRenderer2.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (leftHandCollision3)
            {
                lOutlineRenderer3.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                lOutlineRenderer3.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (rightHandCollision3)
            {
                rOutlineRenderer3.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                rOutlineRenderer3.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (leftHandCollision4)
            {
                lOutlineRenderer4.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                lOutlineRenderer4.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (rightHandCollision4)
            {
                rOutlineRenderer4.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                rOutlineRenderer4.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (leftHandCollision5)
            {
                lOutlineRenderer5.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                lOutlineRenderer5.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }

            if (rightHandCollision5)
            {
                rOutlineRenderer5.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            }
            else
            {
                rOutlineRenderer5.material.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }
        }
        if(calibrationMode)
        {
            lOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));
            rOutlineRenderer.material.SetColor("_Color", new Color(0.0f, 1.0f, 0.0f, 1.0f));

        }

    }
}
