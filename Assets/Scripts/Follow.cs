using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform playerTransform;
    //获取Player的transform组件，需在相机的inspector面板将Player赋值给该组件

    private Vector3 cameraShift;

	// Use this for initialization
	void Start () {
       cameraShift = transform.position - playerTransform.position;
       //计算相机与角色之间的坐标距离
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = playerTransform.position + cameraShift;
        //更新相机坐标
        //相机坐标应为更新后的角色坐标加上角色与相机之间的距离
		
	}
}
