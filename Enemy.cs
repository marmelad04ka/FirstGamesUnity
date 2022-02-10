using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{    
public float speed = 10f; 
private Transform target;
private int wavepointIndex =0;  
void Start (){
target = Weapoints.points [0];  
}
void Update(){  
Vector3 dir = target.position - transform.position; 
transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);
if (Vector3.Distance (transform.position, target.position) <= 0.3f) { 
GetNextWaypoint ();
}
}
void GetNextWaypoint () {
if (wavepointIndex >= Weapoints.points.Length - 1) {
if (wavepointIndex == Weapoints.points.Length) wavepointIndex = 0;
target = Weapoints.points [wavepointIndex = 0];
Debug.Log ("yes");
return; 
}
wavepointIndex++;
target = Weapoints.points [wavepointIndex];
}
}
