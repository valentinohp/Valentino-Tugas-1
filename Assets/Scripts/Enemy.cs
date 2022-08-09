using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public int point = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnMouseDown() {
        GameManager.Instance.AddScore(point);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "DestroyEnemy")
        {
            GameManager.Instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}