﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using RimWorld;
using Verse;

namespace SyrNeuter
{
    [StaticConstructorOnStartup]
    public static class AddNeuterRecipes
    {
        static AddNeuterRecipes()
        {
            NeuterRecipeUsers();
        }
        public static void NeuterRecipeUsers()
        {
            NeuterDefOf.Neuter.recipeUsers = new List<ThingDef>();
            NeuterDefOf.AbortPregnancy.recipeUsers = new List<ThingDef>();
            NeuterDefOf.MakeInfertile.recipeUsers = new List<ThingDef>();
            NeuterDefOf.ReverseInfertility.recipeUsers = new List<ThingDef>();
            foreach (ThingDef t in DefDatabase<ThingDef>.AllDefs.Where((ThingDef d) => d.category == ThingCategory.Pawn && d.race.IsFlesh && d.race.Animal))
            {
                NeuterDefOf.Neuter.recipeUsers.Add(t);
                NeuterDefOf.AbortPregnancy.recipeUsers.Add(t);
                NeuterDefOf.MakeInfertile.recipeUsers.Add(t);
                NeuterDefOf.ReverseInfertility.recipeUsers.Add(t);
            }
        }
    }
}
