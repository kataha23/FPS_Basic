using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float BulletSpeed = 10;

    private void Fire(Vector3 movedir)
    {
        transform.position += movedir.normalized * BulletSpeed * Time.deltaTime;
    }

    void Start()
    {
        Fire(transform.forward);
    }

    void Update()
    {
        Fire(transform.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log(other.name);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
