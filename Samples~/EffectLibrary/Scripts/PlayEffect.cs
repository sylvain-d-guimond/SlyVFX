using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[RequireComponent(typeof(VisualEffect))]
[ExecuteInEditMode]
public class PlayEffect : MonoBehaviour
{
    public float Delay = 2.0f;

    private VisualEffect effect;

    private void Awake()
    {
        effect = GetComponent<VisualEffect>();
    }

    private void OnEnable()
    {
        StartCoroutine(CoPlay());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator CoPlay()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Delay);

            effect.Play();
        }
    }
}
