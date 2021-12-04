using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollowPointer : MonoBehaviour
{
    public GameObject pointer;
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointer.activeSelf && (pointer.transform.position - transform.position).magnitude > 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointer.transform.position, speed * Time.deltaTime);
            transform.forward = pointer.transform.position - transform.position;
        }
    }
}
