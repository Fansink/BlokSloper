﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosinBlocks = Input.mousePosition.x / Screen.width * 16;
        print(mousePosinBlocks);
	}
}