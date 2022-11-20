using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleFallEffect : MonoBehaviour
{
    [SerializeField] JuiceSO _settings;
    [SerializeField] List<MMFeedbacks> _feedbacks;

    private void Awake()
    {
        if (_settings.Options.SpawnEffectEnabled) MMFeedbacksPlay.Play(_feedbacks);
    }
}
