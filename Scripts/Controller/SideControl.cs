using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideControl : Player
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _leftPos, _rightPos;
    [SerializeField] private Player _player;
    [SerializeField] private bool _sideOnClick;

    public void SideMove(string _nameSide)
    {
        if (_nameSide == "right")
        {
            _sideOnClick = true;
        }
        if (_nameSide == "left")
        {
            _sideOnClick = false;
        }
    }

    private void FixedUpdate()
    {
        if (_sideOnClick == true)
        {
            Move(_speed, _rightPos, _player.gameObject);
        }
        else
        {
            Move(_speed, _leftPos, _player.gameObject);
        }
    }
}
