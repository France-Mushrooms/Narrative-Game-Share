using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoaderSctipt : MonoBehaviour
{
    [Tooltip("the name of the next scene to load")]
    public string nextSceneName;

    private void OnTriggerEnter2D(Collider2D  collision)
    {
        if(collision.CompareTag("Player"))
        LoadNextScene();
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
