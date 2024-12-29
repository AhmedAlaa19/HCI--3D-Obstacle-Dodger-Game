using UnityEngine;

public class DropOnCollide : MonoBehaviour
{
    [SerializeField] BoxCollider boxCollider;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] Rigidbody rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer.enabled = false; 
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Other)
    {

       
        if (Other.gameObject.tag == "Player")
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;

            rigidBody.AddForce(0,-100,0, ForceMode.Impulse);
        }
    }

    
}
