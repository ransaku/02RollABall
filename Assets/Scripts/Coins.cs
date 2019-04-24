using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-1, -2, 1));
        //（0，1，0）绕Y轴方向旋转，1s调用60次，1次旋转1度，1s旋转60度。
	}
}
