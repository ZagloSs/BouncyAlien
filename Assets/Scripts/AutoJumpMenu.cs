using System;
using UnityEditor;
using UnityEngine;

public class AutoJumpMenu : MonoBehaviour
{
    public static AutoJumpMenu instance;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private Sprite[] sprites;
    private Rigidbody2D rb;
    private Sprite sprite;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        GameManager.instance.skin = sprite;
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ps.Play();
        rb.velocity = Vector3.up * 12f;
    }

    public float GetPos()
    {
        return transform.position.y;
    }

    public void changeSkinLeft()
    {
        int indexSprite = Array.IndexOf(sprites, sprite);
        if(indexSprite == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[sprites.Length-1];
            
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[indexSprite - 1];
            
        }
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        GameManager.instance.skin = sprite;


    }
    public void changeSkinRight()
    {
        int indexSprite = Array.IndexOf(sprites, sprite);
        if (indexSprite + 1 == sprites.Length)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
            
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[indexSprite + 1];
            
        }
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        GameManager.instance.skin = sprite;
    }
}
