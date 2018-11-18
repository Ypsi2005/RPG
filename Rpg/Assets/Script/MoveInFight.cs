using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInFight : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool _move;
    private Vector3 _target;
    private Grass _grass; 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _target.z = transform.position.z;
            if (_move == false)
            {
                _move = true;
            }
        }

        if (_move)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
            
        }
    }


}