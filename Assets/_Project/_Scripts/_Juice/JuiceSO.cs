using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Juice", menuName = "Juice/Settings", order = 22)]
public class JuiceSO : ScriptableObject
{
    public JuiceSettings Options { get; set; }
}

[Serializable]
public class JuiceSettings
{
    public bool ColorsEnabled { get; set; }
    public bool SpawnEffectEnabled { get; set; }
    public bool BallSquishEnabled { get; set; }
    public bool BallRotationEnabled { get; set; }
    public bool BallFlashEnabled { get; set; }
    public bool CameraShakeEnabled { get; set; }
    public bool WallWobbleEnabled { get; set; }
    public bool BallHitSoundEnabled { get; set; }
    public bool WinSoundEnabled { get; set; }
    public bool BackgroundMusicEnabled { get; set; }
    public bool BallHitParticleEffectEnabled { get; set; }
    public bool BallTrailEnabled { get; set; }
    public bool EyeFollowEnabled { get; set; }
    public bool WinParticleEffectEnabled { get; set; }
}
