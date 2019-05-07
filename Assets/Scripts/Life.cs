using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [Header("Assets Life")]
    [SerializeField] private int life;
    [SerializeField] private float speed;

    private void Update()
    {
        //Movement to the left every deltatime
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Detect player collision to add an extra life
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().health += life;
            Destroy(gameObject);
        }
    }
}
