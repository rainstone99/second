using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody2D rigid2D;
    public float moveSpeed = 3f;
    private bool RotateRange;
    void Start()
    {
        rigid2D.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
        float randomZ = Random.Range(0f, 2f);
        RotateRange = randomZ > 1f;
    }

 
    void Update()
    {

        if(RotateRange)
        {
            transform.Rotate(Vector3.back, Time.deltaTime * 80f);
        }
        else
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * 40f);
        }
        
        transform.localScale -= Vector3.one * moveSpeed * Time.deltaTime;

        if (transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
