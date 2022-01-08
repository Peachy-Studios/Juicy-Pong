using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MMFeedbacksPlay
{
    public static void Play(List<MMFeedbacks> feedbacks)
    {
        foreach (MMFeedbacks feedback in feedbacks)
        {
            Play(feedback);
        }
    }

    public static void Play(MMFeedbacks feedback)
    {
        feedback.Initialization();
        feedback.PlayFeedbacks();
    }
}
