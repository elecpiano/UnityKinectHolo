using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
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
            this.transform.Translate(0.2f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(-0.2f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0f, 0f, -0.2f);
            camera.fieldOfView -= 0.2f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0f, 0f, 0.2f);
            camera.fieldOfView += 0.2f;
        }
    }
}
