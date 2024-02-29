using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcumalakaAudioManager : MonoBehaviour
{
      public GameObject sfxAudioSource;

	private void Start()
	{
		// jalankan BGM saat game dimulai
		
	}
	
	// fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
	
	// fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
	public void PlaySFX (Vector3 spawnPosition) 
    { 
	// berbeda dengan bgm, disini kita buat script untuk 
	// memunculkan prefabnya pada posisi sesuai dengan parameternya
	GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}