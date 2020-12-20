using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerForAll : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadMainScene()
    {
        AkSoundEngine.StopAll();

        SceneManager.LoadScene(0);
    }

    public void Load2DSoundScene()
    {
        AkSoundEngine.StopAll();

        SceneManager.LoadScene(1);
    }

    public void Load3DSoundScene()
    {
        AkSoundEngine.StopAll();

        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
