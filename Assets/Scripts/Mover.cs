using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float sensetivity = 10f;
    private Vector2 mouseTurn;
    private bool isLocked = false;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();       
        LookAtMouse();
        LockMouse();
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
        
    }

    void LookAtMouse()
    {
        mouseTurn.x = Input.GetAxis("Mouse X") * sensetivity ;       
        transform.Rotate(Vector3.up * mouseTurn.x);
    }

    void LockMouse()
    {   if (Input.GetKeyDown(KeyCode.E) && isLocked == false)
        {
            Cursor.lockState = CursorLockMode.Locked;   
            isLocked = true;
        }   
        else if (Input.GetKeyDown(KeyCode.E) && isLocked == true)  
        {
            Cursor.lockState = CursorLockMode.None;
            isLocked = false;
        }
       
    }
}
