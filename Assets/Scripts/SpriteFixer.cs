using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpriteFixer : MonoBehaviour
{
    public Transform Reset;
    // Start is called before the first frame update
    void Start()
    {
        Reset = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Reset.position = Vector3.zero;
        }
    }
}
