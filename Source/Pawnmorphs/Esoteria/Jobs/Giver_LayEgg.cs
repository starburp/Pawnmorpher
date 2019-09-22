﻿// Giver_LayEgg.cs modified by Iron Wolf for Pawnmorph on 09/22/2019 9:19 AM
// last updated 09/22/2019  9:19 AM

using JetBrains.Annotations;
using RimWorld;
using Verse;
using Verse.AI;

namespace Pawnmorph.Jobs
{
    /// <summary>
    /// job giver for making a human pawn lay eggs 
    /// </summary>
    public class Giver_LayEgg : ThinkNode_JobGiver
    {

        [CanBeNull]
        protected override Job TryGiveJob(Pawn pawn)
        {
            if (pawn.health.hediffSet.GetFirstHediffOfDef(MutationsDefOf.EtherEggLayer)?.TryGetComp<HediffComp_Production>()
             == null) return null;

            var pos = RCellFinder.RandomWanderDestFor(pawn, pawn.Position, 2.5f, null, Danger.Some);
            var job = new Job(PMJobDefOf.PMLayEgg, pos);
            return job; 
        }
    }
}