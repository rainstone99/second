using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody2D rigid2D;
    public float moveSpeed = 3f;

    void Start()
    {
        rigid2D.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

 
    void Update()
    {
        transform.localScale -= Vector3.one * moveSpeed * Time.deltaTime;

        if (transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
