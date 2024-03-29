using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObjectPool _pool;
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField]private GameObject pivotPoint;
     private float _timer;
    [SerializeField] private float maxBound = 15f;
    [SerializeField] private float minBound = 9f;
    private bool eventOn = false;

    public static PipeSpawner instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            if (!eventOn) { SpawnPipe(); }
            _timer = 0;
        }

        _timer += Time.deltaTime;

    }

    private void SpawnPipe()
    {
        GameObject pipe = _pool.GetInactiveGameObject();
        if (pipe) 
        {
            pipe.SetActive(true);
            pipe.transform.position = new Vector3(Random.Range(minBound,maxBound),transform.position.y,0);
            pipe.transform.rotation = transform.rotation; 
           
        }
    }

    public Vector3 getPivot()
    {
        return pivotPoint.transform.position;
    }

    public void ToggleEventOn()
    {
        eventOn = !eventOn;
    }


}
