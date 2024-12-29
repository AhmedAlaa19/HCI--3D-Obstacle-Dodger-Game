using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public bool isHit = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            isHit = true;
            Debug.Log(isHit);
        }
    }
}