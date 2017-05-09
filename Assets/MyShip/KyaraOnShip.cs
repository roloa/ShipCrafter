using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// shipに乗っているキャラクター。

public class KyaraOnShip : MonoBehaviour {


    private int speed = 2;

    public MyShip parentShip;

    public void onCreate(MyShip parentShip)
    {
        // インスタンス化時の初期化処理とか。
        this.parentShip = parentShip;

    }

    // Use this for initialization
    void Start () {
		

	}

    // Update is called once per frame
    void Update () {

        // WASDキーで動く。マウス操作はあとで考える。
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Time.deltaTime * speed, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Space.World);
        }


        transform.LookAt(parentShip.getShipCamera().transform.position);
        

    }




}
