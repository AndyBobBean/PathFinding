namespace GUI.Classes
{
    using System;
    using System.IO;

    public class Sounds
    {
        public const int TotalSounds = 50;
        public Stream[] Sound = new Stream[TotalSounds + 1];
        public System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        private readonly bool _enableSound;

        public Sounds(bool enableSound)
        {
            _enableSound = enableSound;
        }

        public void LoadSounds()
        {
            for (var i = 0; i < TotalSounds; i++)
            {
                Sound[i] = File.OpenRead($"Sounds\\Beep{i}.wav");
            }
            Sound[TotalSounds] = File.OpenRead("Sounds\\Ding.wav");
        }

        private void CreateSoundFiles()
        {
            const int min = 300;
            const int max = 1000;

            for (var i = 0; i < TotalSounds; i++)
            {
                var frequency = max - (max - min) / TotalSounds * i;
                GenerateSound(i, frequency);
            }
        }

        private static void GenerateSound(int step, double frequency)
        {
            var stream = new FileStream($"Sounds\\Beep{step}.wav", FileMode.Create);
            var writer = new BinaryWriter(stream);
            const int riff = 0x46464952;
            const int wave = 0x45564157;
            const int formatChunkSize = 16;
            const int headerSize = 8;
            const int format = 0x20746D66;
            const short formatType = 1;
            const short tracks = 1;
            const int samplesPerSecond = 44100;
            const short bitsPerSample = 16;
            const short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            const int bytesPerSecond = samplesPerSecond * frameSize;
            const int waveSize = 4;
            const int data = 0x61746164;
            const int samples = 1000;
            const int dataChunkSize = samples * frameSize;
            const int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

            writer.Write(riff);
            writer.Write(fileSize);
            writer.Write(wave);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);
            //double aNatural = 220.0;
            double ampl = 10000;
            var perfect = 1.5;
            var concert = 1.498307077;
            var freq = frequency * perfect;
            for (var i = 0; i < samples; i++)
            {
                var t = i / (double)samplesPerSecond;
                var s = (short)(ampl * Math.Sin(t * freq * 2.0 * Math.PI));
                writer.Write(s);
            }
            freq = frequency * concert;
            for (var i = 0; i < samples; i++)
            {
                var t = i / (double)samplesPerSecond;
                var s = (short)(ampl * Math.Sin(t * freq * 2.0 * Math.PI));
                writer.Write(s);
            }
            for (var i = 0; i < samples; i++)
            {
                var t = i / (double)samplesPerSecond;
                var s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * perfect * 2.0 * Math.PI)));
                writer.Write(s);
            }
            for (var i = 0; i < samples; i++)
            {
                var t = i / (double)samplesPerSecond;
                var s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * concert * 2.0 * Math.PI)));
                writer.Write(s);
            }
            writer.Close();
            stream.Close();
        }

        public void PlaySound(int step)
        {
            if (step == 0 || !_enableSound) return;
            if (step > TotalSounds) step = TotalSounds;

            Player.Stop();
            Player.Stream = Sound[step];
            Player.Stream.Position = 0;
            Player.PlaySync();
        }

    }
}
