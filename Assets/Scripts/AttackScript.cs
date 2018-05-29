using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Sprite attack;
    public Sprite idle;
    public SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            sr.sprite = attack;
        }
        else
        {
            sr.sprite = idle;
        }

    }
}