using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour {

	public GameObject CollectImag;
	public bool collectable;
	public string prefToEdit;
	public int amount;

	void Start()
	{
		//CollectImag = GameObject.Find ("Collect");
	}

	void OnTriggerEnter(Collider Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			//CollectImag = GameObject.Find ("Collect");
			collectable = true;
			CollectImag.SetActive (true);
		}
	}

	void Update(){
		if (collectable != true){
			return;
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			PlayerPrefs.SetInt (prefToEdit, PlayerPrefs.GetInt (prefToEdit) + amount);
			CollectImag.SetActive (false);
			Destroy (transform.parent.gameObject);
		}
	}

	void OnTriggerExit(Collider Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			collectable = false;
			CollectImag.SetActive (false);
		}
	}

}
