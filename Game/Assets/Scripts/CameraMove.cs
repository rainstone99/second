using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CameraMove : MonoBehaviour
{
    // int ScoreNow = ScoreAmount.Instance.score;
    void Update()
    {
        transform.Rotate(Vector3.back, Time.deltaTime * 40f);
        // if (ScoreNow >50)
        // {
        //     transform.Rotate(Vector3.forward, Time.deltaTime * 40f);
        // }
        // else if (ScoreNow > 100)
        // {
        //     transform.Rotate(Vector3.back, Time.deltaTime * 60f);
        // }
    }
}
