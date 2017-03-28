using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pathmaker : MonoBehaviour {
	int count = 0;
	public GameObject mainCam;
	public GameObject FloorPreFab1;
	public GameObject FloorPreFab2;
	public GameObject FloorPreFab3;
	public Transform PathmakerSpherePreFab;
	float SpawnPathmakerNumber;
	float TurnNumber;
	float LifeCount;
	float TileNumber;
	List<GameObject> FloorTiles = new List<GameObject>();
	bool rayCastSaw1;
	bool rayCastSaw2;
	bool rayCastSaw3;
	public static int TileCount = 0;
	// Use this for initialization
	void Start () {
		TurnNumber = Random.Range (0.01f, 0.5f);
		LifeCount = Random.Range (100f, 1000f);
		TileNumber = Random.Range (0.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		SpawnPathmakerNumber = Random.Range (0.0f, 1.0f);
		if (count < LifeCount) {
			if (SpawnPathmakerNumber < TurnNumber) {
				transform.Rotate (0f, 90f, 0f);
			} 
			if (SpawnPathmakerNumber > 0.4f && SpawnPathmakerNumber < 0.5f) {
				transform.Rotate (0f, -90f, 0f);
			}
			if (SpawnPathmakerNumber >= 0.995f && SpawnPathmakerNumber <= 1.0f) {
				Instantiate (PathmakerSpherePreFab, transform.position, Quaternion.identity);
			}
			if (TileNumber > 0.0f && TileNumber < 1.0f) {
				GameObject FloorTileClone = (GameObject)Instantiate (FloorPreFab1, transform.position, Quaternion.identity);
			}
			if (TileNumber > 1.0f && TileNumber < 2.0f) {
				GameObject FloorTileClone = (GameObject)Instantiate (FloorPreFab2, transform.position, Quaternion.identity);
			}
			if (TileNumber > 2.0f && TileNumber < 3.0f) {
				GameObject FloorTileClone = (GameObject)Instantiate (FloorPreFab3, transform.position, Quaternion.identity);
			}
			//FloorTiles.Add (FloorTileClone);
			Pathmaker.TileCount++;
			transform.Translate (Vector3.forward * 1f);
			count++;
//			mainCam.transform.position += new Vector3 (0, 0.3f, 0);

		} else {
			Destroy (this.gameObject);
		}
		if (TileCount >= 500) {
			Destroy (this.gameObject);
		}
			
	}
	void OnCollionEnter(Collider other){
		Debug.Log ("Hit");
	}
}
