namespace SRP.v2
{
    internal class SoundBox
    {
        private int soundLevel = 0;
        public int SoundLevel => soundLevel;

        public void SoundUp()
        {
            if (soundLevel >= 10)
            {
                return;
            }

            soundLevel++;
            OutputCurrentSoundLevel();
        }


        public void SoundDown()
        {
            if (soundLevel <= 0) 
            {
                return;
            }

            soundLevel--;
            OutputCurrentSoundLevel();
        }

        public void OutputCurrentSoundLevel()
        {
            Output($"Sound level: {soundLevel}");
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
