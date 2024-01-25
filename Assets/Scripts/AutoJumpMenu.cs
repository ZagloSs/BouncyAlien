using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJumpMenu : MonoBehaviour
{

    [SerializeField] private ParticleSystem ps;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ps.Play();
        rb.velocity = Vector3.up * 12f;
    }
}
