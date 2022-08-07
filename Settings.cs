using System.IO;
using System.Reflection;
using ModSettings;
using UnityEngine;

namespace SnowShelterDecay
{
    internal class SettingsMain : JsonModSettings
    {
        protected override void OnConfirm()
        {
            base.OnConfirm();
        }

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(EnableMod) ||
                field.Name == nameof(DecayPerc))
            {
                RefreshFields();
            }
        }
        public void RefreshFields()
        {
            SetFieldVisible(nameof(DecayPerc), Settings.options.EnableMod);
        }



        [Section("General")]

        [Name("Enable Mod")]
        [Description("Turn the mod on/off.")]
        public bool EnableMod = true;

        [Name("HP/day")]
        [Description("The number of HP lost in a day by the snow shelter default is 100.")]
        [Slider(0, 300,301)]
        public int DecayPerc = 100;


    }


    internal static class Settings
    {
        public static SettingsMain options;

        public static void OnLoad()
        {
            options = new SettingsMain();
            options.AddToModSettings("Snow Shelter Decay");
            Settings.options.RefreshFields();
        }

    }


}
