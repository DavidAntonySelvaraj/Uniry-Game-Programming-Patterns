using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class UnityBulletPool : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;

    private IObjectPool<Bullet> bulletPool;

    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>(CreateNewBullet,OnGet,OnRelease);
    }

    public Bullet GetBullet()
    {
        Bullet newBullet = Instantiate(bulletPrefab);
        newBullet.SetPool(bulletPool);
        newBullet.transform.SetParent(transform);
        
        return newBullet;
        //return bulletPool.Get();
    }

    Bullet CreateNewBullet()
    {
        return Instantiate(bulletPrefab);
    }

    void OnGet(Bullet bullet)
    {
        bullet.gameObject.SetActive(true);
    }
    void OnRelease(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }


}//class




















































