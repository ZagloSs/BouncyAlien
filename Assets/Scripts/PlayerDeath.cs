using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private GameObject bsTxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            if(PlayerPrefs.GetInt("bs", 0) < Score.instance.getScore())
            {
                bsTxt.SetActive(true);
                PlayerPrefs.SetInt("bs", Score.instance.getScore());
            }
            else
            {
                bsTxt.SetActive(false);
            }


            GameManager.instance.GameOver();
            AudioManager.instance.PlaySoundEffect(deathSound);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
