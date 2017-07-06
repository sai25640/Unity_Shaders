using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public GameObject npc;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
		//Debug.Log(Vector3.Distance(pointLight.transform.position,cube.transform.position));
		//Debug.Log(Vector3.Cross(new Vector3(-5,4,1),new Vector3(3,-1,2)));
		Vector3 a = player.transform.position- npc.transform.position;
		Vector3 b = npc.transform.forward;
		Debug.Log(Vector3.Dot(a,b));
		Debug.Log(Mathf.Acos(Vector3.Dot(a.normalized,b.normalized)) * Mathf.Rad2Deg);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 a = player.transform.position- npc.transform.position;
		Vector3 b = npc.transform.forward;
		Debug.Log(Vector3.Dot(a,b));
		Debug.Log(Mathf.Acos(Vector3.Dot(a.normalized,b.normalized)) * Mathf.Rad2Deg);
	}
}
