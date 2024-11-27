using UnityEngine;

public class flyatplayer : MonoBehaviour
{

    [SerializeField] Transform player;
    Vector3 playerPosition; 
    [SerializeField] float moveSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed);
    }
}
