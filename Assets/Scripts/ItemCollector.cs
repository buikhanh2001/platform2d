using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Apple = 0;

    [SerializeField] private Text AppleText;

    [SerializeField] private AudioSource collectionSoundeffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectionSoundeffect.Play();
            Destroy(collision.gameObject);
            Apple++;
            AppleText.text = "" + Apple;
        }
    }
}
