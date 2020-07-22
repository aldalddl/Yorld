using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempButtonScript : MonoBehaviour
{
    public Transform tree;
    public Vector3 plane;
    public Quaternion quater;
    public GameObject marker;

    public void OnClickNewTree()
    {
        marker = GameObject.FindGameObjectWithTag("imgTarget");
        plane = GameObject.FindGameObjectWithTag("plane").transform.position;
        if (marker.transform.position.x != 0) //화면에 마커가 포착됐는지 검사해야 하는데 뭔가 잘못 됨...
        {
            plane.y = plane.y + 0.2f;
            quater = GameObject.FindGameObjectWithTag("plane").transform.rotation;
            Instantiate(tree, plane, quater).SetParent(marker.transform);
        }
    }
}
