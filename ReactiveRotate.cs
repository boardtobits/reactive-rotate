using UnityEngine;
using System.Collections;

public class ReactiveRotate : MonoBehaviour {

	public Vector2 angleRange = new Vector2(4f, 4f);
	public bool inverseX;
	public bool inverseY;

	Vector2 mousePos;
	Vector2 baseRotation;


	// Use this for initialization
	void Start () {
		baseRotation = new Vector2 (transform.rotation.eulerAngles.x - angleRange.x * 0.5f,
									transform.rotation.eulerAngles.y - angleRange.y * 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = new Vector2 (Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
		float xRot = ( inverseY ? 1 - mousePos.y : mousePos.y) * angleRange.x + baseRotation.x;
		float yRot = ( inverseX ? 1 - mousePos.x : mousePos.x) * angleRange.y + baseRotation.y;
		transform.localRotation = Quaternion.Euler (new Vector3 (xRot, yRot));
	}
}
