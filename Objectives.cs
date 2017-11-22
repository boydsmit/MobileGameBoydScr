using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public bool _collectedAll;
    private int _collectedNr = 0;
    public float _toCollect;

     public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Objective")
        {
           _collectedNr++;
            if (_collectedNr >= _toCollect)
            {
                _collectedAll = true;
                Debug.Log("All objectives grabbed");
            }
            Destroy(collision.gameObject);
        }
        
    }
}

