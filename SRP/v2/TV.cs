namespace SRP.v2
{
    internal class TV
    {
        private SoundBox soundBox = new();

        private bool on = false;
        public void On()
        {
            on = true;

            soundBox.Output("TV is On...");
            soundBox.OutputCurrentSoundLevel();
            for (int i = 0; i < 5; i++)
            {
                soundBox.SoundUp();
            }
            soundBox.OutputCurrentSoundLevel();
            soundBox.SoundUp();
            soundBox.OutputCurrentSoundLevel();
        }
        public void Off()
        {
            on = false;
            soundBox.Output("TV is Off...");
        }

        public void SelectChannel(int channelNumber)
        {
            if (!on)
            {
                return;
            }

            soundBox.Output($"Channel #{channelNumber} selected");
        }
    }
}
