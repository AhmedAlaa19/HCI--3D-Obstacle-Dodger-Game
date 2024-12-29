using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myMeshRender;

    Rigidbody myRigidbody;

    float passedTime = 3;

    void Start()
    {
        myMeshRender = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRender.enabled = false;
        myRigidbody.useGravity = false;

    }


    void Update()
    {

        if (Time.time > passedTime)
        {
            myMeshRender.enabled = true;
            myRigidbody.useGravity = true;
        }

        //Debug.Log(Time.time);
    }

}
