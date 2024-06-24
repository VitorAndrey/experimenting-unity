using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float steerSpeed = 150f;

    [SerializeField]
    private float movingSpeed = 5f;

    void Start() { }

    void Update()
    {
        float frameDuration = Time.deltaTime;

        float movingAmount = Input.GetAxis("Vertical") * movingSpeed * frameDuration;
        if (movingAmount == 0)
            return;

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * frameDuration;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, movingAmount, 0);
    }
}
