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
    float test = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -10))
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

        ZoomAmount += Input.GetAxis("Mouse ScrollWheel");
        test = ZoomAmount * 3;
        ZoomAmount = Mathf.Clamp(ZoomAmount, -MaxToClamp, MaxToClamp);
        var translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), MaxToClamp - Mathf.Abs(ZoomAmount));
        //gameObject.transform.Translate(0, 0, translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")));
        gameObject.transform.Translate(0, 0, test);
    }
}
