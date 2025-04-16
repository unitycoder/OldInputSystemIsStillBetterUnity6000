using UnityEngine;

public class Heavy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < 1_000_000; i++)
        {
            var x = new Vector3(Mathf.Sin(i), Mathf.Cos(Time.time), Random.value);
            var y = new Vector3(Mathf.Sin(i*2), Mathf.Cos(Time.time*3), Random.value*4);
            var z = new Vector3(Mathf.Sin(i * 3), Mathf.Cos(Time.time * 4), Random.value * 5);

            float dotProduct = Vector3.Dot(x, y);
        }

    }
}
