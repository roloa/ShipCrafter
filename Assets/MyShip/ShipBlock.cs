using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 船を構成するブロック。


public class ShipBlock : MonoBehaviour {

    // 6面。
    public GameObject Top;
    public GameObject Bottom;
    public GameObject Left;
    public GameObject Right;
    public GameObject Forward;
    public GameObject Back;

    // ボードの面に対応する定数
    public const int FACE_TOP    = 1;
    public const int FACE_RIGHT  = 2;
    public const int FACE_FOWARD = 3;
    public const int FACE_LEFT   = 4;
    public const int FACE_BACK   = 5;
    public const int FACE_BOTTOM = 6;

    // 親のshipへの参照。
    private MyShip parentShip;
    // ship内での座標。
    private int x;
    private int y;
    private int z;



    public void onCreate(MyShip parentShip, int x, int y, int z) {
        // インスタンス化時の初期化処理とか。
        this.parentShip = parentShip;
        this.x = x;
        this.y = y;
        this.z = z;

    }

    // Use this for initialization
    void Start () {

        // 各ボードにクリックイベントを追加できる？

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void onMouseDown(int face)
    {
    }


    public void onMouseClick(int face)
    {
        parentShip.onClickBlock(this, face);
    }



}
