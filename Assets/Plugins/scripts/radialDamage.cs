using UnityEngine;
using System.Collections;

public class radialDamage : MonoBehaviour {
	
	Collider2D[] colliders;
	
	public void ExplosionDamage(Vector3 center, float radius, float damage)
	{
		// Get all the colliders? 
		colliders = Physics2D.OverlapCircleAll (center, radius);
		for(int i = 0; i < colliders.Length; i++)
		{
			if(colliders[i].tag == "enemy")
			{
				colliders[i].SendMessage("doDamage", damage);
				Debug.Log ("hit" + colliders[i].name);
			}
		}
	}
}
		 