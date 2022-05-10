using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimMobile : MonoBehaviour
{

    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;

    public float SensitifX, sensitifY;
    public Transform badan;

    void Start()
    {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x >= Screen.width / 2)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    FirstPoint = touch.position;
                    xAngleTemp = xAngle;
                    yAngleTemp = yAngle;
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    SecondPoint = touch.position;
                    xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) / Screen.width;
                    yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) / Screen.height;

                    this.transform.localRotation = Quaternion.Euler(-yAngle * sensitifY, 0, 0.0f);
                    badan.transform.localRotation = Quaternion.Euler(0, xAngle * SensitifX, 0);
                }
            }

            else if (Input.touchCount > 1)
            {
                Touch touch2 = Input.GetTouch(1);
                if (touch2.position.x >= Screen.width / 2)
                {
                    if (touch2.phase == TouchPhase.Began)
                    {
                        FirstPoint = touch2.position;
                        xAngleTemp = xAngle;
                        yAngleTemp = yAngle;
                    }
                    if (touch2.phase == TouchPhase.Moved)
                    {
                        SecondPoint = touch2.position;
                        xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) / Screen.width;
                        yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) / Screen.height;

                        this.transform.localRotation = Quaternion.Euler(-yAngle * sensitifY, 0, 0.0f);
                        badan.transform.localRotation = Quaternion.Euler(0, xAngle * SensitifX, 0);
                    }
                }
            }

        }

    }
}
