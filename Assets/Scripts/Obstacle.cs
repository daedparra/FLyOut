using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField] private int damage;
    [SerializeField] private float speed;
    [Header("Collision Particles")]
    [SerializeField] private GameObject Obseffect;
    [SerializeField] private GameObject Chareffect;

    private CamShake shake;
    private CharHurt charHurt;
    private void Start()
    {
        //getting instances for the camera to move
        shake = GameObject.FindGameObjectsWithTag("ScreenShake")[0].GetComponent<CamShake>();
        charHurt = GameObject.FindGameObjectsWithTag("charMove")[0].GetComponent<CharHurt>();
    }
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Enemie Colliding with Player, so the camera will move, a particle collision will spawn
            shake.shake();
            Instantiate(Chareffect, other.transform.position, Quaternion.identity);
            charHurt.shake();
            other.GetComponent<Player>().health -= damage;
            other.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
