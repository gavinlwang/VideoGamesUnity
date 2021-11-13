using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float delay = 1f;
    bool gameHasEnded = false;
    public GameObject gameoverUI;
    public CanvasGroup cg; 

    public void EndGame ()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            deathscene();
        }
        
    }

    void deathscene ()
    {
        gameoverUI.SetActive(true);
    }

    void FixedUpdate()
    {
        if ((Input.GetKey("enter")) && (gameHasEnded == true))
        {
            GetComponent<CanvasGroup>().alpha = 0;

        }

    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    


}
