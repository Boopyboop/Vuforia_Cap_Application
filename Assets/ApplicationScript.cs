using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationScript : MonoBehaviour {

    //private Animator m_Animator;
    //public GameObject canvasTexteAffiche = GameObject.FindGameObjectWithTag("text");
    public GameObject imageSalle;
    public TextMesh textMesh;
    // Get canvas from the GameObject.

    private bool boolSalle = false;
    private bool boolDescription = true;
    private bool boolLlien = false;
    private string Salle = "salle de reunion 1";
    private string description="pas de réunion";
    private string lien="pas de lien pour cette salle pour l'instant";
    private string texteaffiche;
    public Vector3 positiontexte = Vector3.zero;
    

    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
        /*canvasTexteAffiche.AddComponent<Canvas>();
        Canvas canvas;
        canvas = canvasTexteAffiche.GetComponent<Canvas>();*/

        // Create the Text GameObject.
        GameObject textGO = GameObject.FindGameObjectWithTag("text");

        positiontexte.x = -0.3f;
        positiontexte.y = 0.5f;
        positiontexte.y = 0.0f;
        textGO.transform.parent = imageSalle.transform;
        textGO.transform.position= imageSalle.transform.position+ positiontexte; //on veut que le texte apparaisse un peu au dessus de l'image
        texteaffiche = "salle de reunion 1";

        // Set Text component properties.
        textMesh = textGO.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Nom de la salle");
            
            boolSalle = !boolSalle;
            if (boolSalle == true)
            {
                boolDescription = false;
                boolLlien = false;
                textMesh.text = "salle de reunion 1";
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Description de la salle");
            boolDescription = !boolDescription;
            if (boolDescription == true)
            {
                boolSalle = false;
                boolLlien = false;
                textMesh.text = "pas de réunion";
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            boolLlien = !boolLlien;
            if (boolLlien == true)
            {
                boolDescription = false;
                boolSalle = false;
                textMesh.text = "pas de lien SKYPE pour cette sallE";
            }
        }
        //afficher texteaffiche
        Debug.Log("texte affiché =" + texteaffiche);
        Debug.Log("salle =" + Salle);

    }
}
