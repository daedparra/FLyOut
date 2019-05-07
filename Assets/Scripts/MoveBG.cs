using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour {
    [Header("Values for moving the BG")]
    [SerializeField] private float speed;
    [SerializeField] private float endX;
    [SerializeField] private float startX;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x <= endX)
        {
            Vector3 pos = new Vector3(startX, transform.position.y,transform.position.z);
            transform.position = pos;
        }
    }
}
