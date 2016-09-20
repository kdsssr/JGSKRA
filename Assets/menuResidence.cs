using UnityEngine;
using System.Collections;

public class menuResidence : MonoBehaviour {

    public GameObject residences;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void OnMouseDown()
    {
        Debug.Log("Touché");
        residences = Instantiate(residences,Vector3.zero, Quaternion.identity)as GameObject;
        residences.transform.parent = GameObject.Find("Menu").transform;
    }
    
}
