using UnityEngine;

public class Elevate : MonoBehaviour
{
    [SerializeField] private float height = 3f;
    [SerializeField] private float time = 1f;
    private float chrono = 0f;
    private bool isElevating = false;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        isElevating = true;
    }

    private void Update()
    {
        if (isElevating)
        {
            if (chrono <= time)
            {
                chrono += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, startPosition + height * Vector3.up, chrono / time);
            }
        }
    }

}
