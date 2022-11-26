using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour {

    private BrickController _brickController;

    void Start() {
        _brickController = GetComponent<BrickController>();
    }

    public void PerformTakeDamage(float damage, GameObject _particle) {
        _brickController.TakeDamage(damage);
        _particle.GetComponent<AudioSource>().Play();
    }

}
