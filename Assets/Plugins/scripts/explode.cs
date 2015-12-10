using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	public float timeToWait = 10f;
	public float radius = 5f;
	public float damage = 5f;
	public AnimationClip explosion;

	float timer;
	Animator anim;
	plantHealth plantHealthScript;
	radialDamage radialDamageScript;

	void Awake()
	{
		anim = GetComponent<Animator> ();
		plantHealthScript = GetComponent<plantHealth> ();
		radialDamageScript = GetComponent<radialDamage> ();
	}

	void Start()
	{
		Invoke ("Explode", timeToWait);
	}

 	void Explode()
	{
		anim.SetTrigger ("explode");
		//Invoke ("CallDeathMethod", explosion.length+0.75f);
	}

	void PlayExplodingSound()
	{
		SoundEffectsManager._instance.PlayPlantExplosion ();
	}

	void CallDeathMethod()
	{
		plantHealthScript.death ();
	}

	void damageBunnies()
	{
		radialDamageScript.ExplosionDamage (transform.position, radius, damage);
	}

//	void OnDrawGizmosSelected () {
//		// Draw a yellow sphere at the transform's position
//		Gizmos.color = Color.yellow;
//		Gizmos.DrawSphere (transform.position, radius);
//	}
	

}
