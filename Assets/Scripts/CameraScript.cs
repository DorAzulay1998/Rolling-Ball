using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    Vector3 offset; 
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {

    }

    void LateUpdate() 
    {
        transform.position = player.transform.position + offset;
    }
}
