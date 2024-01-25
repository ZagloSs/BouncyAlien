using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            if(PlayerPrefs.GetInt("bs", 0) < Score.instance.getScore())
            {
                PlayerPrefs.SetInt("bs", Score.instance.getScore());
            }

            GameManager.instance.GameOver();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
