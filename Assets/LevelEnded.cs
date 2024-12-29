using Unity.VisualScripting;
using UnityEngine;

public class LevelEnded : MonoBehaviour
{   public bool levelWon = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
            levelWon = true;
            Debug.Log("Level Ended");
        }
    }
}
 