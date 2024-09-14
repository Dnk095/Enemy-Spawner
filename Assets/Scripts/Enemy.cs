using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    
    private Target _target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Cleaner cleaner))
            Destroy(gameObject);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void Init(Target target)
    {
        _target = target;
    }
}
