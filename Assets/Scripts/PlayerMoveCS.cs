﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCS : MonoBehaviour
{
    public float speed;
    private bool move;
    public GameObject point;
    private Vector3 target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            if(move==false)
            {
                move = true;
            }
            Instantiate(point, target, Quaternion.identity);
        }
        if(move==true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);
        }
    }
}
