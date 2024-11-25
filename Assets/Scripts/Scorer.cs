using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("Youve bumped into obstacle so many times:" + hits);
    }
}
