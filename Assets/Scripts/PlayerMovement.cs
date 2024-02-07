using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float jumpForce;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private AudioClip blastEffect;
    [SerializeField] private GameObject skinSelected;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = skinSelected.GetComponent<SpriteRenderer>().sprite;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        foreach (Touch toque in Input.touches)
        {
            if (toque.phase == TouchPhase.Began)
            {
                jump();
            }
        }
    }

    private void jump()
    {
        ps.Play();
        rb.velocity = Vector3.up * jumpForce;
        AudioManager.instance.PlaySoundEffect(blastEffect);
    }

}
