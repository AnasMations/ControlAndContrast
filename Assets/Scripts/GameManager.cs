using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private PlayerManager playerManager;
    // Start is called before the first frame update
    void Start()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadNextScene(float time)
    {
        StartCoroutine(loadNextSceneAfterTime(time));
    }

    IEnumerator loadNextSceneAfterTime(float time)
    {
        Debug.Log("Scene Transition!");
        yield return new WaitForSeconds(time);
        playerManager.fadeAnimator.SetTrigger("fade");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
