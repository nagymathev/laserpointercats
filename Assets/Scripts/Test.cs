using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 5;
    public float movex;
    public float movez;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

        movex = Input.GetAxisRaw("Horizontal");
        movez = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(movex, movez, 0) * speed * Time.deltaTime);
    
    }

}
