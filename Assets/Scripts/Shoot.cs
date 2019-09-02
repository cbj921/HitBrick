using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bulletPrefab;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		//GameObject.Instantiate(bullet,transform.position,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject bullet = GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
			Rigidbody bulletRgd = bullet.GetComponent<Rigidbody>();
			bulletRgd.velocity = transform.forward * speed;
		}
	}
}
