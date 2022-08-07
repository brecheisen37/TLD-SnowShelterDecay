using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using MelonLoader;
using ModSettings;
using UnityEngine;

namespace SnowShelterDecay
{
    public class PatchClass
    {


    }

    public class Implementation : MelonMod
    {
        public override void OnApplicationLateStart()
        {
            MelonDebug.Msg($"[{Info.Name}] Version {Info.Version} loaded!");

        }

        public override void OnApplicationStart()
        {
            Settings.OnLoad();
        }


        public override void OnSceneWasInitialized(int level, string name) // finished loading scene
        {


        }



        public override void OnUpdate()
        {

        }

    }

}






