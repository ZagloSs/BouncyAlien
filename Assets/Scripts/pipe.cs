using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{

    private float pivotPoint;
    [SerializeField] private float rotationSpeed = 200f;

    private Vector3 pivot;

    private void Start()
    {
        pivot = PipeSpawner.instance.getPivot();
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(pivot, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
       
        if (transform.position.y < pivot.y)
        {
   
            gameObject.SetActive(false);
            
        }
    }


}
