﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingSystem : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject m_target;
    private Vector3 m_lastKnownPosition = Vector3.zero;
    public Quaternion m_lookAtRotation;

    // Update is called once per frame
    void Update()
    {
        if (m_target)
        {
            if (m_lastKnownPosition != m_target.transform.position)
            {
                m_lastKnownPosition = m_target.transform.position;
                m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
            }
            if (transform.rotation != m_lookAtRotation)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);

            }
        }

    }

    // Start is called before the first frame update
    public void SetTarget(GameObject target)
    {
        m_target = target;
    }


}