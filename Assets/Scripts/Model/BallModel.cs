using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModel : MonoBehaviour {
    [ContextMenuItem("Reset", "Resetar")]
    [Range(0, 100)]
    [SerializeField] private float _power;
    [Range(0, 100)]
    [SerializeField] private float _speed;
    [Space(20)]
    [SerializeField] private Vector2 _direction;

    public Vector2 Direction { get => _direction; set => _direction = value; }
    public float Power { get => _power; set => _power = value; }
    public float Speed { get => _speed; set => _speed = value; }

    private void Reset() 
    {
        Power = 0;
        Speed = 0;
        Direction = Vector2.zero;
    }
}
