using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.IO;

namespace BatmanPlatform
{
    class MusicPlayer
    {

        #region Shoot Laser
        private static string temporaryFilePathLaser;

        private static MemoryStream memoryStreamLaser;

        private static FileStream LaserTempFileStream;

        private static WindowsMediaPlayer laserShootSound = new WindowsMediaPlayer();
        #endregion

        #region Background
        private static string temporaryFilePathBackground;

        private static MemoryStream memoryStreamBackground;

        private static FileStream BackgroundTempFileStream;

        private static WindowsMediaPlayer BackgroundPlayer = new WindowsMediaPlayer();
        #endregion

        #region Reduce Health
        private static string temporaryFilePathHealth;

        private static MemoryStream memoryStreamHealth;

        private static FileStream HealthTempFileStream;

        private static WindowsMediaPlayer HealthPlayer = new WindowsMediaPlayer();
        #endregion

        #region Destroy Target
        private static string temporaryFilePathDestroy;

        private static MemoryStream memoryStreamDestroy;

        private static FileStream DestroyTempFileStream;

        private static WindowsMediaPlayer DestroyPlayer = new WindowsMediaPlayer();
        #endregion

        #region Explosion
        private static string temporaryFilePathExplosion;

        private static MemoryStream memoryStreamExplosion;

        private static FileStream ExplosionTempFileStream;

        private static WindowsMediaPlayer ExplosionPlayer = new WindowsMediaPlayer();
        #endregion

        private static SoundPlayer enemyHitSound;

        private static SoundPlayer[] levelSound = new SoundPlayer[7];

        private static SoundPlayer gameOverSound;


        public static void SettingUpMusicProperties()
        {
            HandleBackgroundSetUp();
            HandleShootSoundSetUp();
            HandleEnemyHitSoundSetUp();
            HandleLevelSoundSetUp();
            HandleExplosionSoundSetUp();
            HandleReduceHealthSoundSetUp();
            HandleGameOverSetUp();
            HandleTragetDestroySetUp();

        }

        public static void HandleTragetDestroySetUp()
        {
            temporaryFilePathDestroy = String.Format("{0}{1}{2}", Path.GetTempPath(), Guid.NewGuid().ToString("N"), ".mp3");

            memoryStreamDestroy = new MemoryStream(Properties.Resources.targetdestroy);
            DestroyTempFileStream = new FileStream(temporaryFilePathDestroy, FileMode.Create, FileAccess.Write);

            memoryStreamDestroy.Position = 0;
            memoryStreamDestroy.WriteTo(DestroyTempFileStream);

            DestroyPlayer.settings.setMode("loop", false);
        }
        
        public static void HandleGameOverSetUp()
        {
            gameOverSound = new SoundPlayer(Properties.Resources.gameover);
        }

        public static void HandleBackgroundSetUp()
        {
            temporaryFilePathBackground = String.Format("{0}{1}{2}", System.IO.Path.GetTempPath(), Guid.NewGuid().ToString("N"), ".mp3");

            memoryStreamBackground = new MemoryStream(Properties.Resources.mShortSadLeave);
            BackgroundTempFileStream = new FileStream(temporaryFilePathBackground, FileMode.Create, FileAccess.Write);

            memoryStreamBackground.Position = 0;
            memoryStreamBackground.WriteTo(BackgroundTempFileStream);

            BackgroundPlayer.settings.setMode("loop", false);
            BackgroundPlayer.settings.volume = 30;
        }

        public static void HandleShootSoundSetUp()
        {
            temporaryFilePathLaser = String.Format("{0}{1}{2}", System.IO.Path.GetTempPath(), Guid.NewGuid().ToString("N"), ".mp3");

            memoryStreamLaser = new MemoryStream(Properties.Resources.laser);
            LaserTempFileStream = new FileStream(temporaryFilePathLaser, FileMode.Create, FileAccess.Write);

            memoryStreamLaser.Position = 0;
            memoryStreamLaser.WriteTo(LaserTempFileStream);

            laserShootSound.settings.setMode("loop", false);
            laserShootSound.settings.volume = 100;
        }

        public static void HandleEnemyHitSoundSetUp()
        {
            enemyHitSound = new SoundPlayer(Properties.Resources.enemyHit);
        }

        public static void HandleLevelSoundSetUp()
        {
            levelSound[0] = new SoundPlayer(Properties.Resources.phaserUp1);
            levelSound[1] = new SoundPlayer(Properties.Resources.phaserUp2);
            levelSound[2] = new SoundPlayer(Properties.Resources.phaserUp3);
            levelSound[3] = new SoundPlayer(Properties.Resources.phaserUp4);
            levelSound[4] = new SoundPlayer(Properties.Resources.phaserUp5);
            levelSound[5] = new SoundPlayer(Properties.Resources.phaserUp6);
            levelSound[6] = new SoundPlayer(Properties.Resources.phaserUp7);
        }

        public static void HandleExplosionSoundSetUp()
        {
            temporaryFilePathExplosion = String.Format("{0}{1}{2}", Path.GetTempPath(), Guid.NewGuid().ToString("N"), ".mp3");

            memoryStreamExplosion = new MemoryStream(Properties.Resources.explosionT_T);
            ExplosionTempFileStream = new FileStream(temporaryFilePathExplosion, FileMode.Create, FileAccess.Write);

            memoryStreamExplosion.Position = 0;
            memoryStreamExplosion.WriteTo(ExplosionTempFileStream);

            ExplosionPlayer.settings.setMode("loop", false);
        }

        public static void HandleReduceHealthSoundSetUp()
        {
            temporaryFilePathHealth = String.Format("{0}{1}{2}", Path.GetTempPath(), Guid.NewGuid().ToString("N"), ".mp3");

            memoryStreamHealth = new MemoryStream(Properties.Resources.mreduceHealth);
            HealthTempFileStream = new FileStream(temporaryFilePathHealth, FileMode.Create, FileAccess.Write);

            memoryStreamHealth.Position = 0;
            memoryStreamHealth.WriteTo(HealthTempFileStream);

            HealthPlayer.settings.setMode("loop", false);
        }


        public static void PlayBackgroundMusic()
        {
            BackgroundPlayer.URL = temporaryFilePathBackground;
            BackgroundPlayer.controls.play();
        }

        public static void PlayShootSound()
        {
            //Play your file

            if(!(laserShootSound.playState == WMPPlayState.wmppsPlaying))
            {
                laserShootSound.URL = temporaryFilePathLaser;
                laserShootSound.controls.play();
            }
        }

        public static void PlayZombieHitSound()
        {
            enemyHitSound.Play();
        }

        public static void PlayLevelSound(int level)
        {
            levelSound[level].Play();
        }

        public static void PlayExplosionSound()
        {
            ExplosionPlayer.URL = temporaryFilePathExplosion;
            ExplosionPlayer.controls.play();
        }

        public static void PlayReduceHealthSound()
        {
            HealthPlayer.URL = temporaryFilePathHealth;
            HealthPlayer.controls.play();
        }

        public static void PlayGameOverSound()
        {
            gameOverSound.Play();
        }

        public static void PlayTargetDestroySound()
        {
            DestroyPlayer.URL = temporaryFilePathDestroy;
            DestroyPlayer.controls.play();
        }
    }
}
