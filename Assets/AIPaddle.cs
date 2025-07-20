using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Transform ball;
    public float speed = 5f;
    public float maxOffset = 0.5f;
    public float changeOffsetInterval = 2f;

    private float offset = 0f;
    private float timer = 0f;

    void Start()
    {
        // Initialize with random offset
        offset = Random.Range(-maxOffset, maxOffset);
    }

    void Update()
    {
        if (ball != null)
        {
            // Update offset periodically
            timer += Time.deltaTime;
            if (timer >= changeOffsetInterval)
            {
                offset = Random.Range(-maxOffset, maxOffset);
                timer = 0f;
            }

            // Target position with offset
            Vector2 targetPosition = new Vector2(transform.position.x, ball.position.y + offset);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}

