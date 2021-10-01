using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationStart : MonoBehaviour
{
    // Start is called before the first frame update

    private bool _isMusicMute = false;
    void Start()
    {
        AudioManager.PlayMusic(MusicType.PharaohsCurse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestPlaySfx();
        }
    }


    private void TestPlaySfx()
    {
        AudioManager.PlaySFX(SFXType.Clamp);
    }

    [ContextMenu("Change Music")]
    private void TestChangeToOtherMusic()
    {
        AudioManager.PlayMusic(MusicType.StemB);
    }

    [ContextMenu("Mute/Unmute music")]
    private void TestMuteUnMuteMusic()
    {
        _isMusicMute = !_isMusicMute;
        AudioManager.MuteMusic(_isMusicMute);
    }
}
