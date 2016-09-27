using UnityEngine;
using System.Collections;

public class menuRessources : MonoBehaviour
{

    public GameObject ressources;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        Debug.Log("Touché");
        if ((GameObject.FindGameObjectWithTag("MenuRessources") == null))
        {
            GameObject LeClone = Instantiate(ressources, Vector3.zero, Quaternion.identity) as GameObject;
            LeClone.transform.parent = GameObject.Find("Menu").transform;
            LeClone.transform.localScale = new Vector3(0.02f, 0.3f, 0);
            LeClone.transform.localPosition = new Vector3(0.05f, 0.25f, 0);
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("MenuRessources"));
        }
    }
}
