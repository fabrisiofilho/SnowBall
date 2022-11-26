using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {

    private PlayerController _playerController;

    void Start() 
    {
        _playerController = GetComponent<PlayerController>();
    }

    void Update() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        _playerController.Move(horizontal);
    }

}
