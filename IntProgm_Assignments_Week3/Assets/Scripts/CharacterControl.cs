using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterControl : MonoBehaviour
{
    private NavMeshAgent nav;
    [SerializeField] private Transform coinTransform;
    private bool findCoin;
    
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(findCoin ? coinTransform.position : transform.position + new Vector3(Random.Range(-15f, 15f), Random.Range(-10f, 10f), Random.Range(-15f, 15f)));
        if (Input.GetKeyDown(KeyCode.F) && !findCoin)
        {
            findCoin = !findCoin;
            Invoke("CoinDodge", 3f);
        }
    }

    void CoinDodge()
    {
        var coinAnim = coinTransform.gameObject.GetComponent<Animator>();
        coinAnim.SetTrigger("DodgeTrigger");
    }
}
