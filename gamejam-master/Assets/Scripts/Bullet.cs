using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // mermi h�z�
    public float lifetime = 2f; // mermi ya�am s�resi (saniye)

    private float lifeTimer = 0f;
    public int damage = 10;

    void Update()
    {
        // hareket etme
        transform.position -= transform.forward * speed * Time.deltaTime;

        // ya�am s�resi kontrol�
        lifeTimer += Time.deltaTime;
        if (lifeTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
