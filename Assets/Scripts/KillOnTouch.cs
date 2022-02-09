using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
