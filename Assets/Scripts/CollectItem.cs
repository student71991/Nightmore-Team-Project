using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{

    private int collectibles = 0;

    //[SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            //collectSoundEffect.Play();
            Destroy(collision.gameObject);
            collectibles++;
        }
    }

}
