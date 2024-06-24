using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowingCam : MonoBehaviour
{
    [SerializeField]
    GameObject driver;

    // Update is called once per frame
    void Update()
    {
        transform.position = driver.transform.position + new Vector3(0, 0, -10);
    }
}
