using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMovement : MonoBehaviour {
    [Range(0,10)]
    public float moveSpeed;

	void Update () {
        Vector3 m_location = this.gameObject.transform.position;
        if (Input.GetKey(KeyCode.W)) { this.gameObject.transform.Translate(new Vector3(moveSpeed, 0, 0), Space.Self); }
        if (Input.GetKey(KeyCode.A)) { this.gameObject.transform.Translate(new Vector3(0, 0, moveSpeed), Space.Self); }
        if (Input.GetKey(KeyCode.S)) { this.gameObject.transform.Translate(new Vector3(-moveSpeed, 0, 0), Space.Self); }
        if (Input.GetKey(KeyCode.D)) { this.gameObject.transform.Translate(new Vector3(0, 0, -moveSpeed), Space.Self); }
    }
}
