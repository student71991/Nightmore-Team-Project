using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    [SerializeField] private AudioSource deathSoundEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            RestartLevel();
        }
    }
    private void RestartLevel()
    {
        deathSoundEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
