using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FROGKID2
{

    public class Planet : MonoBehaviour
    {

        [SerializeField]
        Transform transform;

        [SerializeField]
        float rateScale = 1.001f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.localScale *= rateScale;
        }
    }
}