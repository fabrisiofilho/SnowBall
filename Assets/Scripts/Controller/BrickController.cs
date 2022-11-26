using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BrickController : MonoBehaviour {

    private BrickModel _brickModel;
    private AudioSource _audioSource;

    void Start() 
    {
        _brickModel = GetComponent<BrickModel>();
    }

    public void TakeDamage(float damage) 
    {
        _brickModel.Health = _brickModel.Health - damage;

        if (_brickModel.Health <= 0) {
            Destroy(gameObject, 0.05f);
        }
    }

}
