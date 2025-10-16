using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float steerSpeed = 0.01f;

    void Start()
    {
        //transform.Rotate(0, 0, 45);
    }


    void Update()
    {
        float move = 0f;
        float steer = 0f;


        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            //Debug.Log("We are pushing forward");
            move = 1f;
        }
        else if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            //Debug.Log("We are pushing backwards");
            move = -1f;
        }
        
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            //Debug.Log("We are pushing left");
            steer = 1f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            //Debug.Log("We are pushing right");
            steer = -1f;
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
