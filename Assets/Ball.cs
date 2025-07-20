using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    void Start(){
        startPosition = transform.position;
        Launch();
    }

    public void Reset(){
        rb.linearVelocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
        
    }

    private void Launch(){

        float x = Random.Range(0, 2) < 0.5f ? -1 : 1;
        float y = Random.Range(0, 2) < 0.5f ? Random.Range(-0.5f, -1f) : Random.Range(0.5f, 1f);
        rb.linearVelocity = new Vector2(speed * x , speed * y);
    }
}


