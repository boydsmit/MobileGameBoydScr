using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endPoint : MonoBehaviour
{

    private Vector3 _playerLoc;
    private Scene _nextLevel;
    private Scene _scene;
    private Objectives _objectives;
    public int _posXS, _posZS;
    private int _posXE,_posZE;
    public int _pointSize;

    // Use this for initialization
    void Start()
    {
        //Sets the size of the end point.
        _posXE = _posXS + _pointSize;
        _posZE = _posZS + _pointSize;

        //Grabs scene related info
        _scene = SceneManager.GetActiveScene();
        _nextLevel = SceneManager.GetSceneByBuildIndex(_scene.buildIndex + 1);

        //grabs 'Objectives' script
        _objectives = gameObject.GetComponent<Objectives>();
    }

    void Update()
    {
        //Get the Coordinates of the player
        _playerLoc = transform.position;

        //check if the player is within the given coordinates and if all the objectives have been collected
        if (_playerLoc.x >= _posXS && _playerLoc.x <= _posXE && _playerLoc.z >= _posZS && _playerLoc.z <= _posZE && _objectives._collectedAll == true)
        {
            Debug.Log("On Point!");
            if(_nextLevel != null)
            {
                SceneManager.LoadScene(_scene.buildIndex + 1);
            }
        }
    }
}
