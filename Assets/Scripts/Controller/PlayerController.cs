using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    private PlayerModel _playerModel;
    private Transform _playerTransform;

    void Start() 
    {
        _playerModel = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
    }

    public void Move(float horizontal)
    {
        float positionHorizontal = _playerTransform.position.x;
        if ((positionHorizontal < 2302f && horizontal > 0f) || (positionHorizontal > 1629f && horizontal < 0f)) {
            _playerTransform.Translate(horizontal * _playerModel.Speed, 0f, 0f);
        }

        if (positionHorizontal < 1629f) {
            _playerTransform.Translate(0.05f * _playerModel.Speed, 0f, 0f);
        }
    }

    public void RemoveLife() {
        if (_playerModel.Life == 0) {
            SceneManager.LoadScene("Lose");
        }
        _playerModel.Life -= 1;
    }


    public int GetUserLife() {
        return _playerModel.Life;
    }
    
}
