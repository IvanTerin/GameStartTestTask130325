using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
   // [SerializeField] private Animator _animator;
    private float _oldMousePositionX;
    private float _mousePositionEulerY;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            _oldMousePositionX = Input.mousePosition.x;
        //    _animator.SetBool("Run", true);
        }
        //if (Input.GetMouseButtonUp(0)) {
        //    _animator.SetBool("Run", false);
        //}

        if (Input.GetMouseButton(0)) {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;

            float deltaMouseX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _mousePositionEulerY += deltaMouseX;
            _mousePositionEulerY = Mathf.Clamp(_mousePositionEulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _mousePositionEulerY, 0);
        }
    }
}
