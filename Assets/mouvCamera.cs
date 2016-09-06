using UnityEngine;
using System.Collections;

public class mouvCamera : MonoBehaviour {

    

    private Camera cameraFreeWalk;
    public float zoomSpeed = 30f;
    public float minZoomFOV = 10f;

    // Use this for initialization
    void Start () {
	
	}

    public float sl = 2f;
    public float sr = 0.2f;
    public float su = 0.2f;
    public float sd = 0.2f;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)&&(transform.position.x > -10))
        {
            transform.Translate((float)-sl, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 10))
        {
            transform.Translate((float)sr, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < 7))
        {
            transform.Translate(0, su, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > -7))
        {
            transform.Translate(0, -sd, 0);
        }
      
    }

    public void ZoomIn()
    {
        cameraFreeWalk.fieldOfView -= zoomSpeed / 8;
        if (cameraFreeWalk.fieldOfView < minZoomFOV)
        {
            cameraFreeWalk.fieldOfView = minZoomFOV;
        }
    }
}
