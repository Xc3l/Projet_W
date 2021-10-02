using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
	//Speed du perso
	public float speed;

	//l'axe du mouvement
	private string move = "Vertical";
	private string moveh = "Horizontal";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	float moveAxev = Input.GetAxis(move);
    	float moveAxeh = Input.GetAxis(moveh);
    	ApplyInput(moveAxev, moveAxeh);
        
    }

    private void ApplyInput(float moveAxev, float moveAxeh){
    	deplace(moveAxev);
    	deplaceh(moveAxeh);
    }

    private void deplace(float input){
    	// .forward : avant du modèle
    	// input : entre -1 et 1
    	//deltaTime : mouvement par seconde
    	transform.Translate(Vector3.forward * input * speed * Time.deltaTime);
    }

    private void deplaceh(float input){
    	transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }
}

//rigidbodyPerso.velocity = new Vector3(0,0, vDeplacement);
// transform.Translate(Vector3.right * input.GetAxis("Horizontal") * vitesse * Time.deltatime);
