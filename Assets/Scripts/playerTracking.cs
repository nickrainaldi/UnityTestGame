using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTracking : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position;
        offset.y = 1.5f;
    }
    void Update ()
    {
        transform.position = player.transform.position + offset;


		
	}
}
