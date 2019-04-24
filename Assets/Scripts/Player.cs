using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Text text;//需控制Text组件显示分数因此定义一个Text类型
    public GameObject winMessage;//控制WinMessage组件的显示直接操作该组件因此定义GameObject类型
    public int speed = 5;
    //设置speed变量令物体移动速度可控
    private Rigidbody rgd;
    private int score = 0;
    //设置一个私有变量计算分数

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //获得左右和上下按键，返回到h与v的值

        rgd = GetComponent<Rigidbody>();

        rgd.AddForce(new Vector3(h, 0, v) * speed);
        //利用刚体组件给物体施加一个力来控制物体上下左右运动
		
	}
    /* 通过碰撞检测来完成吃掉coin的功能，但碰撞检测吃掉coin时会因发生碰撞而改变运动轨迹因此舍弃此方法。*/
    /*
    void OnCollisionEnter (Collision collision) {

        //collision.collider //获取碰撞器中的碰撞体组件。 
        //string name = collision.collider.name;//获取碰撞到碰撞体的物体名字
        //print(name);

        if (collision.collider.tag == "Coin") {
            Destroy(collision.collider.gameObject);
            //销毁碰撞到的游戏物体
        }
    }
    */


    //通过触发检测来完成该功能
    //需在碰撞体中勾选IsTrigger，勾选IsTrigger后就无法使用碰撞检测了，会穿过物体。
    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Coin") {
            Destroy(collider.gameObject);
            score++;
            text.text = "Score:" + score.ToString();
        }//没有了碰撞体因此直接使用collider来获取触发器组件。
        if (score == 12) {
            winMessage.SetActive(true);
            //激活组件
        }
        
    }

}
