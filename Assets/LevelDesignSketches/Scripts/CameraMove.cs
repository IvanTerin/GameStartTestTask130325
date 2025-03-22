using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform _target;

    private void Start()
    {
        transform.parent = null; // ћетод открепл€ет камеру от плеера в котором лежит    
    }

    void LateUpdate()
    {
        if (_target) {
            transform.position = _target.position;
        }
    }
}
