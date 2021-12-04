using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public RaycastHit hit;
    public Camera cam;
    public float clickRange;
    public LayerMask clickMask;
    public Vector3 clickedPosWorld;

    public GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            pointer.SetActive(true);
        }
        else
        {
            pointer.SetActive(false);
        }



        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Vector3 p1 = ray.origin;
        Vector3 dir = ray.direction;
        Debug.DrawRay(p1, dir * clickRange, Color.yellow, 1.0f);
        if (Physics.Raycast(p1, dir, out hit, clickRange, clickMask))
        {
            pointer.transform.position = hit.point;
        }
    }
}
