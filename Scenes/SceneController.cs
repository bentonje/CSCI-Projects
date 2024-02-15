using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
	[SerializeField] GameObject enemyPrefab;
	[SerializeField] GameObject bananaManPrefab;
	[SerializeField] GameObject capsulePrefab;
	private GameObject enemy;
	private GameObject bananaMan;
	private GameObject capsule;
	
	void Update() {
		if (enemy == null) {
			enemy = Instantiate(enemyPrefab) as GameObject;
			enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			enemy.transform.Rotate(0, angle, 0);
		}

		if (bananaMan == null)
		{
            bananaMan = Instantiate(bananaManPrefab) as GameObject;
            bananaMan.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            bananaMan.transform.Rotate(0, angle, 0);
        }

		if (capsule == null)
		{
			capsule = Instantiate(capsulePrefab) as GameObject;
            capsule.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            capsule.transform.Rotate(0, angle, 0);
		}
	}
}
