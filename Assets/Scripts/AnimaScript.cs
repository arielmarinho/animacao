using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour {
	public float velocidade;
	SpriteRenderer spriteRender;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		spriteRender = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);
		//orientacao sprite
		if (mover_x > 0.0f) {
			spriteRender.flipX = false;
		}
		else if(mover_x < 0.0f) {
			spriteRender.flipX= true;
				
			
		}
		animator.SetFloat ("pMover", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));
	}
}
