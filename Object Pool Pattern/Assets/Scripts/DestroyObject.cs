using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float destroyAfter = 2f;

    private void Start()
    {
        Invoke("DestroyGameObject", destroyAfter);
    }


    private void OnEnable()
    {
        Invoke("DestroyGameObject", destroyAfter);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }

    void DestroyGameObject()
    {
        gameObject.SetActive(false);
    }


}//class


















