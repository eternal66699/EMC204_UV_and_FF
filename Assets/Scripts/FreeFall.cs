using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    public float height;
    public float gravityScale = 1f;

    private float predictedFallDuration;
    void Start()
    {
        float gravity = Mathf.Abs(Physics2D.gravity.y) * gravityScale;
        predictedFallDuration = Mathf.Sqrt(2 * height / gravity);

        Debug.Log("Predicted Fall Duration " + predictedFallDuration + " seconds");

        StartCoroutine(MeasureActualFallDuration());
    }

    private IEnumerator MeasureActualFallDuration()
    {
        while (transform.position.y > 0)
        {
            yield return null;
        }

        float actualFallDuration = Time.timeSinceLevelLoad;

        Debug.Log("Actual Fall Duration " + actualFallDuration + " seconds");

        Debug.Log("Difference: " + Mathf.Abs(predictedFallDuration - actualFallDuration) + " seconds");
    }
}