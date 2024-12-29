using UnityEngine;

public class FlyAtplayer : MonoBehaviour
{   
    [SerializeField] float projectileSpeed = 1.0f;
    [SerializeField] Transform player;
    Vector3 PlayerPos;
    void Start()
    {
       PlayerPos = player.transform.position;     
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Time.deltaTime * projectileSpeed);

        DestroyWhenReached();
        
    }

    void DestroyWhenReached()
    {
        if (transform.position == PlayerPos)
        {
            Destroy(gameObject);
        }
    }
}
