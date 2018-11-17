using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightFloor : MonoBehaviour
{
    public GameObject ground;
    public GameObject border;
 
    GameObject[,] grid = new GameObject[15, 10];
    void Start()
    {

        for (int i = 0; i < 15; i++)
        {
            for (int y = 0; y < 10; y++)
            {

                grid[i, y] = Instantiate(ground, new Vector3(i, y, 0), Quaternion.identity);
                grid[i, y] = Instantiate(border, new Vector3(i, y, 0), Quaternion.identity);
                grid[i, y].name = "Cube" + i + "," + y;
            }
        }
        //The block we skipped we put here.


    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Testing");
            GameObject tmpry = grid[1, 2];
            grid[1, 2] = grid[2, 2];
            grid[2, 2] = tmpry;
            reposition();
        }
    }
    void reposition()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int y = 0; y < 10; y++)
            {
                grid[i, y].transform.position = new Vector3(i, y, 0);
            }
        }
    }
}
