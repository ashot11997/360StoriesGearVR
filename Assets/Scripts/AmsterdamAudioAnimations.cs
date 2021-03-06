using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmsterdamAudioAnimations : MonoBehaviour {

	public GameObject Subtitle1_Row1;
	public GameObject Subtitle1_Row2;
	public GameObject Subtitle2_Row1;
	public GameObject Subtitle2_Row2;
	public GameObject Subtitle2_Row3;
	public GameObject Subtitle3_Row1;
	public GameObject Subtitle3_Row2;
	public GameObject Subtitle3_Row3;
	public GameObject Subtitle4_Row1;
	public GameObject Subtitle4_Row2;
	public GameObject Subtitle5_Row1;
	public GameObject Subtitle6_Row1;
	public GameObject Subtitle6_Row2;
	public GameObject SubCont;

	public GameObject Image1;
	public GameObject Image2;
	public GameObject Image3;
	public GameObject Image4;
	public GameObject RetroPic;

	public GameObject EndedWindow;
	public GameObject soundPlayer;
	public GameObject ImageCont;

	AudioSource audioFile;

	void Start () {


		audioFile = GetComponent<AudioSource> ();
		audioFile.Play ();
	}

	void Update () {
		//Debug.Log (audioFile.time);
		StartCoroutine(mySubtitles());
		myImage();
	}

	float time = 0.30f;

	IEnumerator mySubtitles(){


		

		if (audioFile.time >= 0.70 && audioFile.time <= 1.10) {
			//SubCont.SetActive (true);
			Subtitle1_Row1.SetActive (true);
			Subtitle1_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle1_Row2.SetActive (true);
			Subtitle1_Row2.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle6_Row1.SetActive (true);
			Subtitle6_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
		}else if(audioFile.time > 15.5){
			Subtitle1_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle1_Row2.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle6_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle1_Row1.SetActive (false);
			Subtitle1_Row2.SetActive (false);
			Subtitle6_Row1.SetActive (false);
		}	

		//////////

		if (audioFile.time >= 16 && audioFile.time <= 17) {
			Subtitle2_Row1.SetActive (true);
			Subtitle2_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle2_Row2.SetActive (true);
			Subtitle2_Row2.GetComponent<Animator> ().Play ("SubtitleShow");
			//Subtitle2_Row3.SetActive (true);
			//Subtitle2_Row3.GetComponent<Animator> ().Play ("SubtitleShow");
		}else if(audioFile.time > 26.5){
			Subtitle2_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle2_Row2.GetComponent<Animator> ().Play ("SubtitleHide");
			//Subtitle2_Row3.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle2_Row1.SetActive (false);
			Subtitle2_Row2.SetActive (false);
			//Subtitle2_Row3.SetActive (false);
		}	

		//////////

		if (audioFile.time >= 26.8 && audioFile.time <= 27.2) {
			Subtitle3_Row1.SetActive (true);
			Subtitle3_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle3_Row2.SetActive (true);
			Subtitle3_Row2.GetComponent<Animator> ().Play ("SubtitleShow");
			/*Subtitle3_Row3.SetActive (true);
			Subtitle3_Row3.GetComponent<Animator> ().Play ("SubtitleShow");*/
		}else if(audioFile.time > 35.5){
			Subtitle3_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle3_Row2.GetComponent<Animator> ().Play ("SubtitleHide");
			//Subtitle3_Row3.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle3_Row1.SetActive (false);
			Subtitle3_Row2.SetActive (false);
			//Subtitle3_Row3.SetActive (false);
		}	

		//////////

		/*if (audioFile.time >= 34.5 && audioFile.time <= 35) {
			Subtitle4_Row1.SetActive (true);
			Subtitle4_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle4_Row2.SetActive (true);
			Subtitle4_Row2.GetComponent<Animator> ().Play ("SubtitleShow");
			Subtitle5_Row1.SetActive (true);
			Subtitle5_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
		}else if(audioFile.time > 48){
			Subtitle4_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle4_Row2.GetComponent<Animator> ().Play ("SubtitleHide");
			Subtitle5_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle4_Row1.SetActive (false);
			Subtitle4_Row2.SetActive (false);
			Subtitle5_Row1.SetActive (false);
		}

		//////////

		if (audioFile.time >= 37 && audioFile.time <= 37.2) {
			Subtitle5_Row1.SetActive (true);
			Subtitle5_Row1.GetComponent<Animator> ().Play ("SubtitleShow");
		}else if(audioFile.time > 40.8){
			Subtitle5_Row1.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle5_Row1.SetActive (false);
		}

		//////////

		if (audioFile.time >= 41.20 && audioFile.time <= 41.40) {

			Subtitle6_Row2.SetActive (true);
			Subtitle6_Row2.GetComponent<Animator> ().Play ("SubtitleShow");
		}else if(audioFile.time > 50.7){
			Subtitle6_Row2.GetComponent<Animator> ().Play ("SubtitleHide");
			yield return new WaitForSeconds (time);
			Subtitle6_Row2.SetActive (false);
		}*/

	if (audioFile.time >= 37 && audioFile.time <= 37.5) {
			EndedWindow.SetActive (true);
			soundPlayer.GetComponent<Animator> ().Play ("SoundPlayerOff");
			ImageCont.GetComponent<Animator> ().Play ("ImageContainerOff");
			yield return new WaitForSeconds (time);
			soundPlayer.SetActive (false);
			ImageCont.SetActive (false);
	}
	}

	public void myImage(){
		if (audioFile.time >= 7.5 && audioFile.time <= 7.7) {
			Image1.GetComponent<Animator> ().Play ("Image1ScaleOn");
		}else if(audioFile.time > 13){
			Image1.GetComponent<Animator> ().Play ("Image1ScaleOff");
		}	

		///////////

		if (audioFile.time >= 13.5 && audioFile.time <= 14) {
			Image2.GetComponent<Animator> ().Play ("Image2ScaleOn");
		}else if(audioFile.time > 20){
			Image2.GetComponent<Animator> ().Play ("Image2ScaleOff");
		}	

		///////////

		if (audioFile.time >= 20.5 && audioFile.time <= 21) {
			Image3.GetComponent<Animator> ().Play ("Image3ScaleOn");
		}else if(audioFile.time > 27){
			Image3.GetComponent<Animator> ().Play ("Image3ScaleOff");
		}

		///////////

		if (audioFile.time >= 27.5 && audioFile.time <= 28) {
			Image4.GetComponent<Animator> ().Play ("Image4ScaleOn");
		}else if(audioFile.time > 34){
			Image4.GetComponent<Animator> ().Play ("Image4ScaleOff");
		}

		//////////

		if (audioFile.time >= 3 && audioFile.time <= 3.5) {
			RetroPic.SetActive(true);
		}
	}


}
