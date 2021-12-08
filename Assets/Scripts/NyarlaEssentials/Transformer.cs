using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NyarlaEssentials
{
    public class Transformer : MonoBehaviour
    {
        private Transform _transform;
        public new Transform transform => _transform ??= gameObject.transform;
    
        private RectTransform _rectTransform;
        public RectTransform RectTransform => _rectTransform ??= GetComponent<RectTransform>();

        public Transform[] AllChildren
        {
            get
            {
                Transform[] result = new Transform[transform.childCount];
                for (int i = 0; i < transform.childCount; i++)
                {
                    result[i] = transform.GetChild(i);
                }
                return result;
            }
        }
    }
}