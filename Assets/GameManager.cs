using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   [SerializeField] LevelEnded levelEnded;
    [SerializeField] CollisionDetector collisionDetector;
    [SerializeField] Mover mover;

    void Update()
    {
        if (collisionDetector.isHit == true)
        {
            Debug.Log("Game Over");
            
            Invoke("endGame", 2f);

        }

        if (levelEnded.levelWon == true)
        {
            Debug.Log("Game Won");
            Invoke("gameWon", 2f);
        }

    }

    void endGame()
    {
        Debug.Log("Game Over");
        mover.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void gameWon()
    {
        Debug.Log("Game Won");
        mover.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
