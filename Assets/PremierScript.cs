using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour ! Je suis PremierScript");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bonjour !");

        //Transalation
        //gameObject.transform.Translate(new Vector3(0,0,0.01f));

        Debug.Log(Input.GetAxis("Horizontal"));
       
        /*
        if (Input.GetButtonDown("Fire1"))
        {
      
            //z+ = vers l'avant
            this.transform.Translate(Vector3.forward);
        }
        */
    }

}

/*
class Personne
{
    //attributs (propri�t�s)

    //type + identifiant
    int age;


    //M�thodes (propri�t�s)
    //type + identifiant(param�tre(s)) + code
    void direBonjour()
    {
        Debug.Log("Bonjour !");

        //cr�er un nouvel objet
        //Personne p = new Personne();

        //changer l'�ge de l'objet Personne cr�� pr�c�demment
       // p.age = 10;



    }
}
*/