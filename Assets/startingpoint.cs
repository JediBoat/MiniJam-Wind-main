using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startingpoint : MonoBehaviour
{
    Vector2 startpos;
    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            if (Random.value < 0.5f)
            {
                startpos = new Vector2(131.7f, 3.26f);

            }
            else
            {
                startpos = new Vector2(48.53f, -12.11f);
            }
            transform.position = startpos;
        }
        else if (sceneName == "Level2")
        {
            if (Random.value < 0.5f)
            {
                
                startpos = new Vector2(-18.17f, 6.56f);
            }
            else
            {
                
                startpos = new Vector2(77.39f, -8.13f);
            }
            transform.position = startpos;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
