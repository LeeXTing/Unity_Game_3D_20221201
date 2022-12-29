using UnityEngine;

namespace selena
{
    /// <summary>
    /// 音效系統
    /// </summary>
    /// 要求元件 : 在第一次套用腳本時會添加裡面指定的原件
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">要播放的音效</param>
        public void PlaySound(AudioClip sound)
        {
            // 音樂來源 . 播放一次音效(音效) ;
            aud.PlayOneShot(sound);
        }
    }
}
