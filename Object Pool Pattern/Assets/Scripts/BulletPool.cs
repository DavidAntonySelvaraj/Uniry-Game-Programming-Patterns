using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    [SerializeField] private Bullet bulletPrefab;

    [SerializeField] private List<Bullet> bullets = new List<Bullet>();

    public Bullet GetBullet()
    {
        Bullet newBullet = null;

        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].gameObject.activeInHierarchy)
            {
                newBullet = bullets[i];
                newBullet.gameObject.SetActive(true);
                break;
            }
        }

        if(newBullet == null) 
        {
            newBullet = Instantiate(bulletPrefab);
            bullets.Add(newBullet);
            newBullet.transform.SetParent(transform);
        }

        return newBullet;
        
    }

}//class
































