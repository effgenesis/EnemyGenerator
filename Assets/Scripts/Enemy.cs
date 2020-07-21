using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _speed = 0.2f;
    private Vector3 _direction;
    private Animator _animator;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("Destroy");
    }

    private void Start()
    {
        _direction = new Vector3(Random.Range(-1f , 1f), Random.Range(-1f, 1f), 0);
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(_direction * Time.deltaTime * _speed);
    }
}
