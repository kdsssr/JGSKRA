using UnityEngine;
using System.Collections;

public class affichageRessource : MonoBehaviour
{

    public int nbHabitants = 10;
    public int nbVivres = 100;
    public int nbBois = 200;
    public int nbPierres = 200;

    int incHabitants = 0;
    int incVivres = 0;
    int incBois = 0;
    int incPierres = 0;

    float timeLeft = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            nbVivres -= nbHabitants / 4; 

            nbHabitants += incHabitants;
            nbBois += incBois;
            nbPierres += incPierres;
            nbVivres += incVivres;
            timeLeft = 5.0f;
        }

        GameObject.Find("txtPopulations").GetComponent<TextMesh>().text = "Population : " + nbHabitants;
        GameObject.Find("txtVivres").GetComponent<TextMesh>().text = "Vivres : " + nbVivres;
        GameObject.Find("txtPierres").GetComponent<TextMesh>().text = "Pierres : " + nbBois;
        GameObject.Find("txtBois").GetComponent<TextMesh>().text = "Bois : " + nbPierres;
    }
}