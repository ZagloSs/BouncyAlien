using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pla"))
        {
            Score.instance.increaseScore();
        }
    }
}
