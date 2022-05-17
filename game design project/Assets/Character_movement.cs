using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.left;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.left;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.up;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Time.deltaTime * moveSpeed * Vector2.up;
        }
    }
}
