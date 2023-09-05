using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBucket : MonoBehaviour
{
    //[SerializeField] private GameObject _bucket;
    public float posX = 0, posY = 8;

    // Start is called before the first frame update
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -5), mousePosition, moveSpeed);
        }
        else
        {
            transform.position = new Vector3(posX,posY);
        }

    }
}
