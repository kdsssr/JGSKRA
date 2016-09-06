using UnityEngine;
using System.Collections;

public class mouvCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public float sl = 1;
    public float sr = 1;
    public float su = 1;
    public float sd = 1;
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)&&(transform.position.x > -10))
        {
            transform.Translate(-sl, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 10))
        {
            transform.Translate(sr, 0, 0);
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
}
