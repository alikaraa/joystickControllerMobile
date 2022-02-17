using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;
    
    private void Update(){
        float xMovement = joystick.Horizontal();
        float yMovement = joystick.Vertical();

        transform.position += new Vector3(xMovement, 0f, yMovement * speed * Time.deltaTime);
    }
}
