using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInFight : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _range;
    private bool _move;
    private Vector3 _target;
    private GameObject _grass;

    void Start()
    {
        _grass = GameObject.FindGameObjectWithTag("Ground");
    }

    void OnMouseDown()
    {
        _grass.GetComponent<Grass>().getPosi();

        var test = transform.position.x;
        Debug.Log("x = " + test);
    }


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

            OnMouseDown();
        }

        if (_move)
        {
            _target.x = Mathf.Round(_target.x);
            _target.y = Mathf.Round(_target.y);
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
            Debug.Log("Transformposition = " + _target);
   
        }
    }


}