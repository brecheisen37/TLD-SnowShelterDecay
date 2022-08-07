using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using MelonLoader;

namespace SnowShelterDecay
{
    [HarmonyPatch(typeof(SnowShelter), "Awake")]
    public class PatchStart
    {
        public static void Postfix()
        {
            GameManager.GetSnowShelterManager().m_SnowShelterPrefab.m_DailyDecayHP = Settings.options.DecayPerc;
        }
    }
}
