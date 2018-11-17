using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightUnit : MonoBehaviour
{
    public GameObject d1;
    public GameObject d2;
    GameObject[,] grid = new GameObject[15, 10];
    void Start()
    {
        int rndX = Random.Range(0, 15);
        int rndY = Random.Range(8, 10);

                grid[rndX, rndY] = (GameObject)Instantiate(d1, new Vector3(rndX, rndY, 0), Quaternion.identity);
                grid[rndX, rndY].name = "Cube" + rndX + "," + rndY;
            
        }
        //The block we skipped we put here.


    }

    //void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Debug.Log("Testing");
    //        GameObject tmpry = grid[1, 2];
    //        grid[1, 2] = grid[2, 2];
    //        grid[2, 2] = tmpry;
    //        reposition();
    //    }
    //}
    //void reposition()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        for (int y = 0; y < 10; y++)
    //        {
    //            grid[i, y].transform.position = new Vector3(i, y, 0);
    //        }
    //    }
    //}
//}
