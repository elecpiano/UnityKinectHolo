using UnityEngine;
using System.Collections;

public class CameraController3 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateInput();
    }

    void UpdateInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.2f, 0f, 0f);
            this.transform.Rotate(0f, 1.2f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.2f, 0f, 0f);
            this.transform.Rotate(0f, -1.2f, 0f);
        }
    }
}
