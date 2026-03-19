using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    public string sceneToLoad;
    //[SerializeField] private AudioSource endSoundEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //endSoundEffect.Play();
        SceneManager.LoadScene(sceneToLoad);
    }

}
