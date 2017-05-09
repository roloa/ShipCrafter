using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackLine : MonoBehaviour {

    // トラック同心円
    public LineRenderer track1;
    public LineRenderer track2;
    public LineRenderer track3;

    // Use this for initialization
    void Start () {

        // 円を描くように。
        LineRenderer line = track1;
        line.positionCount = 20;
        for (int i = 0; i < 20; i++)
        {
            float rad = (i * 0.1f) * Mathf.PI;
            float x = Mathf.Cos(rad) * 20;
            float z = Mathf.Sin(rad) * 20;
            line.SetPosition(i, new Vector3(x, 0, z));
        }
        line = track2;
        line.positionCount = 20;
        for (int i = 0; i < 20; i++)
        {
            float rad = (i * 0.1f) * Mathf.PI;
            float x = Mathf.Cos(rad) * 50;
            float z = Mathf.Sin(rad) * 50;
            line.SetPosition(i, new Vector3(x, 0, z));
        }
        line = track3;
        line.positionCount = 20;
        for (int i = 0; i < 20; i++)
        {
            float rad = (i * 0.1f) * Mathf.PI;
            float x = Mathf.Cos(rad) * 100;
            float z = Mathf.Sin(rad) * 100;
            line.SetPosition(i, new Vector3(x, 0, z));
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
}
