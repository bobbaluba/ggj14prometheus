using UnityEngine;
using System.Collections;

public static class GameObjectExtensions {
	//convenience function for getComponent<ComponentType> != null
	public static bool HasComponent<T>(this GameObject gameObject) where T : UnityEngine.Component {
		return gameObject.GetComponent<T>() != null;
	}
	
	public static T GetComponentInParents<T>(this GameObject gameObject) where T : UnityEngine.Component{
		Transform t = gameObject.transform;
		while(t != null){
			T component = t.GetComponent<T>();
			if(component!=null){
				return component;
			}
			t = t.parent;
		}
		return null;
	}

	//easy access to 2d
	public static Vector2 GetPosition2D(this Transform t){
		return new Vector2(t.position.x, t.position.y);
	}

	//easy access to 2d
	public static Vector2 To2D(this Vector3 v){
		return new Vector2(v.x, v.y);
	}

	//easy access to 3d
	public static Vector3 To3D(this Vector2 v, float z=0){
		return new Vector3(v.x, v.y, z);
	}

	public static void AddXForce(this Rigidbody2D rb, float xf){
		rb.AddForce(new Vector2(xf, 0));
	}

	public static void AddYForce(this Rigidbody2D rb, float yf){
		rb.AddForce(new Vector2(0, yf));
	}

	public static void SetXVelocity(this Rigidbody2D rb, float xv){
		rb.velocity = (new Vector2(xv, rb.velocity.y));
	}

	public static void SetYVelocity(this Rigidbody2D rb, float yv){
		rb.velocity = (new Vector2(rb.velocity.y, yv));
	}
}
