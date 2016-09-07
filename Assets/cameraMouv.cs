using UnityEngine;
using System.Collections;

public class cameraMouv : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    float ZoomAmount = 0;
    float MaxToClamp = 5;
    float ROTSpeed = 5;

    public float sl = 0.2f;
    public float sr = 0.2f;
    public float su = 0.2f;
    public float sd = 0.2f;
    float zoom = 0f;

    // Update is called once per frame
    void Update()
    {
        //Déplacement de la caméra
        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -7))
        {
            transform.Translate((float)-sl, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 7))
        {
            transform.Translate((float)sr, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < 5))
        {
            transform.Translate(0, su, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > -5))
        {
            transform.Translate(0, -sd, 0);
        }

        //Zoom de la caméra
        ZoomAmount = Input.GetAxis("Mouse ScrollWheel");
        zoom = ZoomAmount * 3;
        if (transform.position.z < 5 && Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            gameObject.transform.Translate(0, 0, zoom);
        }
        else if (transform.position.z > -5 && Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            gameObject.transform.Translate(0, 0, zoom);
        }
    }
}
