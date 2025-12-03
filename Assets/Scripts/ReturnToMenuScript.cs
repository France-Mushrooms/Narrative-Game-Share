using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMenuScript : MonoBehaviour
{
   [Tooltip("the name of game scene")]
   public string nextSceneName;

   public void Start()
{
    Button button = GetComponent<Button>();
    
    button.onClick.AddListener(StartGame);
}
    private void StartGame()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}