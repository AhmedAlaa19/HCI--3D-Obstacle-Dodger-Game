using TreeEditor;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xValue;
    [SerializeField] private float yValue;
    [SerializeField] private float zValue;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);    
    }
}
