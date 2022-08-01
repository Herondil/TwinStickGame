using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{

    //l'objet de classe Rigidbody attaché au gameobject
    public Rigidbody m_rigidbody;
    public GameObject projectile;
    public Transform parent;
    public GeneralValues HP;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour ! Je suis PremierScript");
        for (var i = 0; i < 10; i++)
        {
            //Création d'un nouveau GameObject
            //GameObject o = Object.Instantiate(projectile,parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bonjour !");

        //Transalation
        //gameObject.transform.Translate(new Vector3(0,0,0.01f));

        Debug.Log(Input.GetAxis("Horizontal"));
       
        
        if (Input.GetButton("Fire1"))
        {
      
            //z+ = vers l'avant
            this.transform.Translate(Vector3.forward);
        }
    
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colision");

        //si on a touché un ennemi ->



    }
}


class Personne
{
    //attributs (propriétés)
    static int populationTotale = 250000000;

    //type + identifiant
    int age;


    //Méthodes (propriétés)
    //type + identifiant(paramètre(s)) + code
    void direBonjour()
    {
        Debug.Log("Bonjour !");

        //créer un nouvel objet
        //Personne p = new Personne();

        //changer l'âge de l'objet Personne créé précédemment
       // p.age = 10;



    }

    void direBonjour(string interlocuteur)
    {
        Debug.Log("Bonjour "+interlocuteur+" !");
    }
}
