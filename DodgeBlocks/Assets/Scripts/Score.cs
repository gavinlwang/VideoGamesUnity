using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text score;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");
    }
}
