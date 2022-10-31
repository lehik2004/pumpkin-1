using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IMove
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _leftSide, _rightSide;
    [SerializeField] private bool _onSideDirection;

    public void Move(float _speed, Transform _side, GameObject _gmbForTransform)
    {
        _gmbForTransform.transform.position = Vector2.MoveTowards(_gmbForTransform.transform.position, new Vector2(_side.position.x,_gmbForTransform.transform.position.y), _speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        СheckSidePos();
        MoveToSide(_onSideDirection);
    }

    private void СheckSidePos()
    {
        if (gameObject.transform.position.x == _leftSide.position.x)
        {
            _onSideDirection = false;
        }
        if (gameObject.transform.position.x == _rightSide.position.x)
        {
            _onSideDirection = true;
        }
    }

    private void MoveToSide(bool SideDir)
    {
        if (SideDir)
        {
            Move(_speed, _leftSide, gameObject);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            Move(_speed, _rightSide, gameObject);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
