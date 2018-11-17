using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private GameManager _manager;
    public GameObject dummy;

    private Board _board;
	// Use this for initialization
	void Start () {
		_manager = GameManager.instance;
	    _board = _manager._Board;
	    Vector3 vec = _board.mAllCells[1, 1].mBoardPosition;
        Instantiate(dummy,vec,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
