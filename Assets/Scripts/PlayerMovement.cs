using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float jumpForce;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private AudioClip blastEffect;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
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
