using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //[SerializeField] private Bullet bulletPrefab;
    //[SerializeField]private BulletPool bulletPool;
    [SerializeField] private UnityBulletPool unityBulletPool;

    private Camera mainCam;

    private void Awake()
    {
        mainCam = Camera.main; 
    }

    private void Update()
    {
        ShootBullet();
    }

    void ShootBullet()
    {   
        if(Input.GetMouseButtonDown(0)) 
        {
            Vector3 shootingDirection = GetShootingDir();

            Bullet newBullet = unityBulletPool.GetBullet();

            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = Quaternion.identity;

            newBullet.SetVelocity(shootingDirection);

           /* Bullet newBullet = bulletPool.GetBullet();

            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = Quaternion.identity;

            newBullet.SetVelocity(shootingDirection);*/

        }
    }

    Vector3 GetShootingDir()
    {
        Vector3 shootDir = Vector3.zero;
        shootDir = Input.mousePosition;
        shootDir.z = 0f;
        shootDir = mainCam.ScreenToWorldPoint(shootDir);
        shootDir = shootDir-transform.position;

        return shootDir;
    }



}//class

































































