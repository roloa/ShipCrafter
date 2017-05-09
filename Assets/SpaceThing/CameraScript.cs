using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {


    // カメラモード
    private int current_camera_mode;
    // 俯瞰カメラ
    // 宙域の中心をクルクル回る
    public const int CAMERA_GLOBAL = 0;

    // ターゲット観察カメラ
    // 指定物体の周りをクルクル回る
    public const int CAMERA_TARGET = 1;
    public Transform target;

    // 3人称敵船注視カメラ
    // 自船から常に敵船を捉えるカメラ
    public const int CAMERA_LOCKON = 2;
    public Transform myShip;
    public Transform enemyShip;


    // 手動カメラの横回転ラジアン
    private float spin_horizonal;
    // 手動カメラの縦回転ラジアン
    private float spin_vertical;
    // 手動カメラの距離
    private float distance; 

    // Use this for initialization
    void Start () {
        current_camera_mode = CAMERA_GLOBAL;
        distance = 55;
        spin_horizonal = 0;
        spin_vertical = 0;
    }
	
	// Update is called once per frame
	void Update () {

        switch (current_camera_mode)
        {
            case CAMERA_GLOBAL:
                // 俯瞰カメラ
                Vector3 vec = new Vector3();
                vec.x = Mathf.Cos(spin_horizonal) * Mathf.Sin(spin_vertical) * distance;
                vec.y =                             Mathf.Cos(spin_vertical) * distance;
                vec.z = Mathf.Sin(spin_horizonal) * Mathf.Sin(spin_vertical) * distance;

                transform.position = vec;

                break;
            case CAMERA_TARGET:
                // 注目カメラ
//                Vector3 vec = target.transform.position;
//                transform.position = vec;

                break;
            case CAMERA_LOCKON:
                // ３人称カメラ
                break;

        }
        transform.LookAt(Vector3.zero);
	}

    // 操作系
    bool isMouseDown = false;
    float mousex;
    float mousey;

    // UIのカメラ操作パネルがドラッグされたら呼ばれる
    public void onDrag()
    {
        spin_horizonal += (Input.mousePosition.x - mousex) * 0.01f;
        spin_vertical  += (Input.mousePosition.y - mousey) * 0.01f;

        mousex = Input.mousePosition.x;
        mousey = Input.mousePosition.y;
    }

    public void onMouseDown()
    {
        isMouseDown = true;
        mousex = Input.mousePosition.x;
        mousey = Input.mousePosition.y;
    }
    public void onMouseUp()
    {
        isMouseDown = false;

    }

}
