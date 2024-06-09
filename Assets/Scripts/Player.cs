using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Say();
    }

    // Update is called once per frame
    void Update()
    {
      // Do nothing  
    }

    void Say() {
        Debug.Log("I'm printing to the console");
    }
}
