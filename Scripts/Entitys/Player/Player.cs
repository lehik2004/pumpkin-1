using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMove
{
    public void Move(float _speed, Transform _side, GameObject _gmbForTransform)
    {
        _gmbForTransform.transform.position = Vector2.MoveTowards(_gmbForTransform.transform.position, _side.position, _speed * Time.deltaTime);
    }
    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
