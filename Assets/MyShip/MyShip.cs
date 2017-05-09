using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 船のスクリプト
// やるべきことー
// 船のカスタマイズ
// 新しくキューブをくっつけて船をつくる
//
// 入力を考える、マウスで突っつくとその面に新しいキューブがくっつく？
// キャラクターを動かして増築箇所を指示する？

// 新しいキューブのプロトタイプ的なものはどこに書けばいい？
// 各キューブには耐久力とかの属性を持たせたい
//


public class MyShip : MonoBehaviour {

    // カメラ
    public Camera shipCamera;

    public ShipBlock blockPrefab;

    // ブロックのリスト
    private ArrayList blockList;
    // 座標指定してアクセスしたい時に使うブロックのマップの配列
    private ShipBlock[,,] blockMap;
    private int blockMapXOrigin;
    private int blockMapZOrigin;

    // Use this for initialization
    void Start() {
        Debug.Log("ship start!");

        blockList = new ArrayList();
        blockMap = new ShipBlock[200, 2, 200];
        blockMapXOrigin = 100;
        blockMapZOrigin = 100;

        // ブロックのプレハブを配置
        createShipBlock(0, 0, 0);


        createShipBlock(0, 0, 1);
        createShipBlock(1, 0, 0);
        createShipBlock(1, 0, 1);

        createShipBlock(0, 0, -1);
        createShipBlock(-1, 0, 0);
        createShipBlock(-1, 0, -1);

    }

    // 船のブロックを指定座標に配置する。
    ShipBlock createShipBlock(int x, int y, int z){
        Vector3 position;
        Quaternion rotation;
        GameObject gobj;
        ShipBlock shipBlock;
        rotation = new Quaternion();
        position = new Vector3(x, y, z);
        //gobj = Instantiate(blockPrefab, position, rotation, transform);

        shipBlock = Instantiate<ShipBlock>(blockPrefab, transform);
        // 一度親の座標で生成してから、指定座標に動かすことで、ローカル座標にする。

        shipBlock.transform.Translate(position);

        shipBlock.onCreate(this, x, y, z);

        putBlockToMap(x, y, z, shipBlock);

        return shipBlock;
    }

    public Camera getShipCamera()
    {
        return this.shipCamera;
    }

    void putBlockToMap(int x, int y, int z, ShipBlock shipBlock){
        // TODO エラーチェック
        blockMap[x + blockMapXOrigin, y, z + blockMapZOrigin] = shipBlock;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.I)){
            transform.Translate(0, 0, Time.deltaTime);
        }


        // クリックされた時
        // 新しいキューブを生成して配置する

    }

   // ブロックがクリックされた時
   public void onClickBlock( ShipBlock block, int face ) {
       string debuglog;

       // とりあえずブロック
       // if()

   }


}

