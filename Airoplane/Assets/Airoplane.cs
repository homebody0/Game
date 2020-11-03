using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airoplane : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0f;
    public float boost = 5f;
    private Transform _airoplane;
    void Start()
    {
        _airoplane = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _airoplane.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            speed += boost;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            speed -= boost;
        }
    }
}
