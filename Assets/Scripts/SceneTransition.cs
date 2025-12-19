using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
   [Tooltip("the name of the next scene to load")]
    public string nextSceneName;
    

      public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
        Debug.Log("Transition Scene!");
    }
}
