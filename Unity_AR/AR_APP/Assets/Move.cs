using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	float timeCounter = 0;

	public float speed2;
	public float width2;
	public float height2;
	private float speed;
	private float width;
	private float height;


	void Start() {
		speed = speed2;
		width = width2;
		height = height2;
	}

	void Update() { 
	timeCounter += Time.deltaTime * speed;

		float y = -1.0f*25.0f;
			float x = Mathf.Sin (timeCounter) *Mathf.Abs(height) * 1.0F;
			float z = Mathf.Cos (timeCounter) * Mathf.Abs(width) * 1.0F;


		transform.position = new Vector3 (x, y, z);


	}
}
