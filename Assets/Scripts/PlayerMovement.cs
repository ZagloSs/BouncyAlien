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
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            jump();
        }
#elif UNITY_ANDROID
        foreach (Touch toque in Input.touches)
        {
            if (toque.phase == TouchPhase.Began)
            {
                jump();
            }
        }
#endif
    }

    private void jump()
    {
        ps.Play();
        rb.velocity = Vector3.up * jumpForce;
        AudioManager.instance.PlaySoundEffect(blastEffect);
    }

}
