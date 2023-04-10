using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            int damage = collision.gameObject.GetComponent<Bullet>().damage;
            UpdateHealth(damage);
        }
    }
   

    public void UpdateHealth(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        // Can çubuðunu için eðer konulursa
        //float healthBarSize = (float)health / 100f;
        //healthBar.transform.localScale = new Vector3(healthBarSize, 1f, 1f);
    }
}
