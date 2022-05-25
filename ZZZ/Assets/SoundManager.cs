using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, fireSound, jumpSound, enemyDeathSound;
    static AudioSource audioSrc;

    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("PlayerDead");
        fireSound = Resources.Load<AudioClip>("RayBlasts");
        jumpSound = Resources.Load<AudioClip>("JumpSound");
        enemyDeathSound = Resources.Load<AudioClip>("ZombieDead");

        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "RayBlasts":
                audioSrc.PlayOneShot(fireSound);
                break;
        }

        switch (clip)
        {
            case "PlayerDead":
                audioSrc.PlayOneShot(playerHitSound);
                break;
        }

        switch (clip)
        {
            case "JumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
        }

        switch (clip)
        {
            case "ZombieDead":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;
        }
    }
}
