using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilMotion : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * speed);
	}
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision dectectada");
        GameObject enemy = collision.collider.gameObject;
        GameObject.Destroy(enemy);
        GameObject missile = this.gameObject;
        GameObject.Destroy(missile);
    }
    
}
