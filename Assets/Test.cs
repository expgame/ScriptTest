using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour{ 
	// Use this for initialization
	void Start () {
		//要素5の配列を初期化する
		int [] array = {100, 30, 20, 80, 10};

		//配列の要素を順番に表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		//配列の要素を逆順に表示する
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
			
		}
	}

	// Update is called once per frame
	void Update () {

	}
}