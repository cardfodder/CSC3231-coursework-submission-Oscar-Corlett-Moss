using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    // movement speed
    [SerializeField]
    float speed = 1f;

    //speed when holding down a boost button
    [SerializeField]
    float boostSpeed = 10f;

    // how sensitive the mouse is
    float sensitivity = 0.25f;
    // where the mouse used to be (plus it's an X-mas joke, bc this is due in December)
    Vector3 exMouse = new Vector3(0, 180, 0);

    // Update is called once per frame
    void Update()
    {
        // do all the mouse angles
        exMouse = Input.mousePosition - exMouse;
        // make sure last value is 0 so it doesn't rotate around on its side and lose the angle
        exMouse = new Vector3(sensitivity * (exMouse.y), exMouse.x * sensitivity, 0);
        exMouse = new Vector3(transform.eulerAngles.x + exMouse.x, transform.eulerAngles.y + exMouse.y, 0);

        transform.eulerAngles = exMouse;
        exMouse = Input.mousePosition;

        Vector3 movement = GetInput();
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            movement = movement * boostSpeed;
        } 
        else {
            movement = movement * speed;
        }

        transform.Translate(movement);
        
    }

    private Vector3 GetInput() {
        Vector3 directionSpeed = new Vector3();
        if (Input.GetKey(KeyCode.W)){
            directionSpeed += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.S)){
            directionSpeed += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A)){
            directionSpeed += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            directionSpeed += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space)){
            directionSpeed += new Vector3(0, 1, 0);
        }
        
        return directionSpeed;
    }
}
