using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pressbutton : MonoBehaviour
{
  public AudioSource m_MyAudioSource;   
  void start()//start of the scene 
  {  
   m_MyAudioSource = GetComponent<AudioSource>();//get the audiosource on the gameobject
   m_MyAudioSource.Stop();//stop the audio when start the scene
  }
  void OnMouseDown()
 {   
   StartCoroutine(ExampleCoroutine());
 }
   IEnumerator ExampleCoroutine()
    {
     m_MyAudioSource.Play();
     yield return new WaitForSeconds(0.2f);//delay time
     SceneManager.LoadScene("scene that you want");
    }
}
