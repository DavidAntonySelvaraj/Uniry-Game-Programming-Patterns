using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D myBody;
    [SerializeField] private float moveSpeed =1f;
    private IObjectPool<Bullet> bulletPool;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity(Vector3 moveVelocity)
    {
        myBody.velocity = new Vector2(moveVelocity.x * moveSpeed, moveVelocity.y * moveSpeed);
    }


    public void SetPool(IObjectPool<Bullet> Pool)
    {
        bulletPool = Pool;
    }

    private void OnBecameInvisible()
    {
        bulletPool.Release(this);
    }

    
}//class




















