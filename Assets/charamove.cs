using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charamove : MonoBehaviour
{

	//Rigidbody2D rb;
  // 速度
  //public Vector2 SPEED = new Vector2(0.05f, 0.05f);
  // Use this for initialization
  void Start()
	{
		//rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		// 移動処理
		Move();
	}
	public static int num = 0;

	// 移動関数
	void Move()
	{
		Vector3 blue = GameObject.Find("blue").transform.position;
		Vector3 blue1 = GameObject.Find("blue (1)").transform.position;
		Vector3 blue2 = GameObject.Find("blue (2)").transform.position;
		Vector3 blue3 = GameObject.Find("blue (3)").transform.position;
		Vector3 green = GameObject.Find("green").transform.position;
		Vector3 green1 = GameObject.Find("green (1)").transform.position;
		Vector3 green2 = GameObject.Find("green (2)").transform.position;
		Vector3 green3 = GameObject.Find("green (3)").transform.position;
		Vector3 red = GameObject.Find("red").transform.position;
		Vector3 red1 = GameObject.Find("red (1)").transform.position;
		Vector3 red2 = GameObject.Find("red (2)").transform.position;
		Vector3 red3 = GameObject.Find("red (3)").transform.position;
		// 現在位置をPositionに代入
		Vector2 Position = transform.position;
		// 左キーを押し続けていたら
		if (Input.GetKeyDown("left"))
		{
			num --;
      // 代入したPositionに対して加算減算を行う
      //Vector3 tmp = GameObject.Find("green").transform.position;
      //float x = tmp.x;
      //Position.x = x;
    }
    else if (Input.GetKeyDown("right"))
		{
			num ++;
			// 右キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			//Position.x += SPEED.x;
		}
		num = num % 12;
		if (num < 0)
    {
			num += 12;
    }
		if (num == 0)
    {
			Position = blue;
		}
		else if (num == 1)
		{
			Position = green;
		}
		else if (num == 2)
		{
			Position = red;
		}
		else if (num == 3)
		{
			Position = blue1;
		}
		else if (num == 4)
		{
			Position = green1;
		}
		else if (num == 5)
		{
			Position = red1;
		}
		else if (num == 6)
		{
			Position = blue2;
		}
		else if (num == 7)
		{
			Position = green2;
		}
		else if (num == 8)
		{
			Position = red2;
		}
		else if (num == 9)
		{
			Position = blue3;
		}
		else if (num == 10)
		{
			Position = green3;
		}
		else if (num == 11)
		{
			Position = red3;
		}
		transform.position = Position;
	}

}
