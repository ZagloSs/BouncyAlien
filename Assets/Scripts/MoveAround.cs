using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotPoint.transform.position, new Vector3(0,0,1), rotationSpeed * Time.deltaTime);
    }
}
