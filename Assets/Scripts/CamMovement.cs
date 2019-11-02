using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    public Transform player;
    private Vector3 prevPlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        prevPlayerPos = player.position;
        transform.position = player.position+new Vector3(0,5,-5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += player.transform.position-prevPlayerPos;
        transform.RotateAround(player.position,Vector3.up,Input.GetAxis("Horizontal")*3);
        prevPlayerPos = player.transform.position;
    }
}
