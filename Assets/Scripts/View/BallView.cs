using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallView : MonoBehaviour {

    private BallController _ballController;
    private BrickController _brickController;
    private int _points = 0;
    private int _life = 3;
    public Text _txtPoints;
    public Text _txtLife;
    public Vector3 pos;

    public int Points { get => _points; set => _points = value; }
    public int Life { get => _life; set => _life = value; }

    void Start() 
    {
        _ballController = GetComponent<BallController>();
        _brickController = GetComponent<BrickController>();
    }


    void Update() 
    {
        pos = transform.position;
        if (pos.y < 0) {
            _ballController.StopBall();
            Life -= 1;
            _txtLife.text = "Life: " + Life;
            if (Life == 0 ) {
                SceneManager.LoadScene("Lose");
            }
            _ballController.StartBall();
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        string tag = collision.gameObject.tag;

        if (tag == "Enemy") {
            BrickView _brickView = collision.gameObject.GetComponent<BrickView>();
            _brickView.PerformTakeDamage(1f, collision.gameObject);
            CountPoints();
        }
        
        if (tag == "Player") {
            _ballController.PerfectAngleReflect(collision);
        } else {
            _ballController.PerfectAngleReflect(collision);
        }
    }

    public void CountPoints() 
    {
        Points += 1;
        _txtPoints.text = "Points: " + Points;
        if (Points == 36) {
            SceneManager.LoadScene("Win");
        }
    }

}
