using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform bulletPosition;
    public GameObject projectile;
    

    void Update()
    {
     //Get Input from player
     if(Input.GetMouseButtonDown(0))
        {
            SoundManager.PlaySound("RayBlasts");
            //spawn a projectile
            Instantiate(projectile, bulletPosition.position, bulletPosition.rotation); //Where to spawn the projectile
        }
    }
}
