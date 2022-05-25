using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip soundEffect;
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        if (other.gameObject.CompareTag("Player"))
        {
            CoinManager.instance.ChangeScore(coinValue);
        }
    }
}
