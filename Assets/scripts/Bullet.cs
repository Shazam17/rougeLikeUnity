using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage = 33;
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    public float distanceToDeath = 2f;
    private float currentDistance = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        currentDistance += 1 * Time.deltaTime;
        if (currentDistance > distanceToDeath)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(gameObject);
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Debug.Log(collision.name);
    }
}
