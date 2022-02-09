using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void Update()
    {
        GetComponent<TMP_Text>().SetText(MovingBlock.score.ToString());
    }
}
