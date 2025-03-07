using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderCollisionDetection : MonoBehaviour
{
    public bool rightCollided = false;
    public bool leftCollided = false;
    public bool rightCollided2 = false;
    public bool leftCollided2 = false;
    public bool rightCollided3 = false;
    public bool leftCollided3 = false;
    public bool rightCollided4 = false;
    public bool leftCollided4 = false;
    public bool rightCollided5 = false;
    public bool leftCollided5 = false;
    public GameObject rightHand;
    public GameObject rightCollider;
    public GameObject rightCollider2;
    public GameObject rightCollider3;
    public GameObject rightCollider4;
    public GameObject rightCollider5;
    public GameObject leftHand;
    public GameObject leftCollider;
    public GameObject leftCollider2;
    public GameObject leftCollider3;
    public GameObject leftCollider4;
    public GameObject leftCollider5;
    public GameObject l_hand_guide;
    public GameObject r_hand_guide;
    private bool leftReadyForCollision = true;
    private bool rightReadyForCollision = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        l_hand_guide.transform.position = leftHand.transform.position;
        r_hand_guide.transform.position = rightHand.transform.position;
        
        if (rightCollider.activeSelf && leftCollider.activeSelf)
        {
            (leftCollided, leftReadyForCollision) = CollisionDetection(leftHand, leftCollider, leftCollided, leftReadyForCollision);
            (rightCollided, rightReadyForCollision) = CollisionDetection(rightHand, rightCollider, rightCollided, rightReadyForCollision);
        }
        else if (rightCollider2.activeSelf && leftCollider2.activeSelf)
        {
            (leftCollided2, leftReadyForCollision) = CollisionDetection(leftHand, leftCollider2, leftCollided2, leftReadyForCollision);
            (rightCollided2, rightReadyForCollision) = CollisionDetection(rightHand, rightCollider2, rightCollided2, rightReadyForCollision);
        }
        else if (rightCollider3.activeSelf && leftCollider3.activeSelf)
        {
            (leftCollided3, leftReadyForCollision) = CollisionDetection(leftHand, leftCollider3, leftCollided3, leftReadyForCollision);
            (rightCollided3, rightReadyForCollision) = CollisionDetection(rightHand, rightCollider3, rightCollided3, rightReadyForCollision);
        }
        else if (rightCollider4.activeSelf && leftCollider4.activeSelf)
        {
            (leftCollided4, leftReadyForCollision) = CollisionDetection(leftHand, leftCollider4, leftCollided4, leftReadyForCollision);
            (rightCollided4, rightReadyForCollision) = CollisionDetection(rightHand, rightCollider4, rightCollided4, rightReadyForCollision);
        }
        else if (rightCollider5.activeSelf && leftCollider5.activeSelf)
        {
            (leftCollided5, leftReadyForCollision) = CollisionDetection(leftHand, leftCollider5, leftCollided5, leftReadyForCollision);
            (rightCollided5, rightReadyForCollision) = CollisionDetection(rightHand, rightCollider5, rightCollided5, rightReadyForCollision);
        }
    }

    private (bool, bool) CollisionDetection(GameObject hand, GameObject collider, bool collided, bool readyForCollision)
    {
        if (collider.transform.position.x + collider.transform.localScale.x > hand.transform.position.x && collider.transform.position.x - collider.transform.localScale.x < hand.transform.position.x &&
            collider.transform.position.y + collider.transform.localScale.y > hand.transform.position.y && collider.transform.position.y - collider.transform.localScale.y < hand.transform.position.y && readyForCollision)
        {
            return (true, false);
        }

        else if (collider.transform.position.x + collider.transform.localScale.x > hand.transform.position.x && collider.transform.position.x - collider.transform.localScale.x < hand.transform.position.x &&
            collider.transform.position.y + collider.transform.localScale.y > hand.transform.position.y && collider.transform.position.y - collider.transform.localScale.y < hand.transform.position.y && !readyForCollision)
        {
            return (collided, readyForCollision); 
        }

        else
        {
            return (false, true);
        }
    }
}
