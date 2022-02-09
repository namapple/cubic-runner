using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    private float startingYPosition;
    public static int score;
    public static int highScore;

    private void Start()
    {
        startingYPosition = transform.position.y;
        score = 0;
    }
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
        if (transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
            float newY = startingYPosition + Random.Range(-1f, 1f);
            transform.position = new Vector3(transform.position.x, newY, 0);
            score++;
            if (score > highScore)
            {
                highScore = score;
            }
        }
    }
}
