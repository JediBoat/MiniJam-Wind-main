using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public int sceneBuildIndex;
    public mckeygrab script;


    private void OnTriggerEnter2D(Collider2D other){
         
         if(other.tag == "Player" && script.keygrabbed == true){
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
         }
    }
}
