using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour {
    private Vector2 targetPos;
    [Header("Amount to move")]
    [SerializeField] private float YPlus;
    [SerializeField] private float Xplus;

    [SerializeField] private float Speed;
    [Header("Bounderies of player")]
    [SerializeField] private float maxLeft;
    [SerializeField] private float maxRight;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;
    [Header("HUD")]
    [SerializeField] private string HealthTextAppend = "x";
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject endScene;
    [SerializeField] private GameObject score;
    [Header("Effects")]
    [SerializeField] private GameObject MoveEffect;
    [SerializeField] private GameObject woosh;


    public int health = 3;
    private CamShake move;

    private void Start()
    {
        move = GameObject.FindGameObjectsWithTag("ScreenShake")[0].GetComponent<CamShake>();
    }

    // Update is called once per frame
    void Update () {
        _text.text = HealthTextAppend + health.ToString("0");
        if (health <= 0)
        {
            endScene.SetActive(true);
            Destroy(score);
            Destroy(gameObject);
        }
        //Movement to the new position
        transform.position = Vector2.MoveTowards(transform.position,targetPos,Speed*Time.deltaTime);
        //Movement Up
        if (Input.GetKeyUp(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + YPlus);
            Move();
            move.move();
        }else if (Input.GetKeyUp(KeyCode.DownArrow) && transform.position.y > minHeight) //Movement Down
        {
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - YPlus);
            Move();
            //transform.position = targetPos;
            move.move();
        }else if (Input.GetKeyUp(KeyCode.LeftArrow) && transform.position.x > maxLeft) //Movement Left
        { 
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x - Xplus, transform.position.y);
            Move();
            //transform.position = targetPos;
            move.move();
        }else if (Input.GetKeyUp(KeyCode.RightArrow) && transform.position.x < maxRight) //Movement Right
        {
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x + Xplus, transform.position.y);
            Move();
            //transform.position = targetPos;
            move.move();
        }

    }

    private void Move()
    {
        woosh.GetComponent<AudioSource>().Play();
    }
}
