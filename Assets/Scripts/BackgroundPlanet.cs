using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundPlanet : MonoBehaviour
{
    [SerializeField] private float minYbound;
    [SerializeField] private float maxYbound;
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    [SerializeField] private float speed;
    [SerializeField] private Sprite[] planetSprites;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < -10)
        {
            
            transform.position = new Vector3(10, Random.Range(minYbound, maxYbound), 0);
            float randomScale = Random.Range(minScale, maxScale);
            transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            gameObject.GetComponent<SpriteRenderer>().sprite = planetSprites[(int)Random.Range(0, planetSprites.Length)];
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-1, 0, 0).normalized * speed;
        }
    }
}
