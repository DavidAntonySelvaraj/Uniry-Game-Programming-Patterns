using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D myBody;
    [SerializeField] private float moveSpeed =1f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity(Vector3 moveVelocity)
    {
        myBody.velocity = new Vector2(moveVelocity.x * moveSpeed, moveVelocity.y * moveSpeed);
    }

}//class




















